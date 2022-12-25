using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnappyWinscard;

namespace NFC_ACR122U_Reader_Writer
{
    public partial class Form1 : Form
    {
        public CardIo CardIo { get; set; }
        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            CardIo = new CardIo();
            CardIo.ReaderStateChanged += OnReaderStateChanged;

            if (ConnectCard())
            {
                CardUIdTextbox.Text = GetCardUId(CardIo);
                StatusTextBox.Text = GetCardStatus(CardIo);
                SubStatusTextBox.Text = GetCardSubStatus(CardIo);
            }
        }

        private void OnReaderStateChanged(CardIo.ReaderState readerState)
        {
            ChangeStatus();
            ChangeCardStatus(textBlockReaderState, readerState.ToString());
        }

        private static void ThreadSafe(Action callback, Form form)
        {
            var worker = new BackgroundWorker();
            worker.RunWorkerCompleted += (obj, e) =>
            {
                if (form.InvokeRequired)
                    form.Invoke(callback);
                else
                    callback();
            };
            worker.RunWorkerAsync();
        }


        public void ChangeStatus()
        {
            if (ConnectCard())
            {
                ChangeStatus(CardUIdTextbox, GetCardUId(CardIo));
                ChangeStatus(StatusTextBox, GetCardStatus(CardIo));
                ChangeStatus(SubStatusTextBox, GetCardSubStatus(CardIo));
                ChangeStatusColor(StatusColorLabel, Color.MediumSeaGreen);
            }
            else
            {
                ChangeStatus(CardUIdTextbox, "Not connected.");
                ChangeStatus(StatusTextBox, "Not connected.");
                ChangeStatus(SubStatusTextBox, "Not connected.");
                ChangeStatusColor(StatusColorLabel, Color.Red);
            }
        }


        public Label ChangeCardStatus(Label label, string mesagge)
        {
            ThreadSafe(() => { label.Text = mesagge; }, this);

            return label;
        }

        public TextBox ChangeStatus(TextBox textBox, string message)
        {
            ThreadSafe(() => { textBox.Text = message; }, this);

            return textBox;
        }

        public Label ChangeStatusColor(Label label, Color color)
        {
            ThreadSafe(() => { label.BackColor = color; }, this);

            return label;
        }

        private bool ConnectCard()
        {
            return CardIo.ConnectCard();
        }

        private string GetCardUId(CardIo cardIo)
        {
            return cardIo.GetCardUID();
        }

        private string GetCardStatus(CardIo cardIo)
        {
            return cardIo.StatusText;
        }

        private string GetCardSubStatus(CardIo cardIo)
        {
            return cardIo.SubStatusText;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var blockNumber = Convert.ToInt32(BlockNumericUpDown.Value);
            var readedText = ReadBlockAsText(blockNumber);

            ReadedTextTextBox.Text = readedText;
        }

        private string ReadBlockAsText(int blockNumber)
        {
            var readedBytes = Read(Convert.ToByte(blockNumber));
            var text = ConvertBytes(readedBytes, TextFormat.Stretched) ?? "";
            return text.Trim().Replace(" ", string.Empty);
        }

        private IEnumerable<byte> Read(byte block)
        {
            var readedBytes = CardIo.ReadCardBlock(block, (byte)0x60, (byte)0x0);

            return readedBytes;
        }

        private static string ConvertBytes(IEnumerable<byte> bytes, TextFormat textFormat)
        {
            try
            {
                var text = bytes.Aggregate("",
                    (s, b) =>
                    {
                        switch (textFormat)
                        {
                            case TextFormat.Hex:
                                return $"{s}{b:X2} ";
                            case TextFormat.Stretched:
                                return $"{s}{(char)b}  ";
                            case TextFormat.Normal:
                                return $"{s}{(char)b}";
                            default:
                                throw new ArgumentOutOfRangeException(nameof(textFormat), textFormat, null);
                        }
                    });
                return text;
            }
            catch (Exception e)
            {
                return "";
            }
        }

        private enum TextFormat
        {
            Hex,
            Normal,
            Stretched
        }


        private static byte[] GetBytes(string text, int length)
        {
            if (text.Length <= length)
                text += new string('\0', length - text.Length);
            else
                text = text.Substring(0, length);


            return text
                .ToCharArray()
                .Select(c => (byte)c)
                .ToArray();
        }

        private bool Write(string text, int blockNumber, int length)
        {
            try
            {
                var bytesToWrite = GetBytes(text, length);
                var block = Convert.ToByte(blockNumber);
                CardIo.WriteCardBlock(bytesToWrite, block, (byte)0x60, (byte)0x0);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        private void WriteButton_Click(object sender, EventArgs e)
        {
            if (ConnectCard())
            {
                var blockNumber = Convert.ToInt32(BlockNumericUpDown.Value);
                var textToWrite = TextToWriteTextBox.Text.Trim();
                var succes = Write(textToWrite, blockNumber, 16);

                MessageBox.Show(succes ? "Ok" : "Error");
            }
            else
            {
                MessageBox.Show("No Connected");
            }
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            var blockNumber = Convert.ToInt32(BlockNumericUpDown.Value);
            var readedText = ReadBlockAsText(blockNumber);

            ReadedTextTextBox.Text = readedText;
        }
    }
}
