using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class Main : Form
    {
        private Rectangle originalFormRect;

        private Rectangle textBoxTxtInput;
        private Rectangle buttonMcOriginalReact;
        private Rectangle buttonMrOriginalReact;
        private Rectangle buttonMplusOriginalReact;
        private Rectangle buttonMminusOriginalReact;
        private Rectangle buttonMsOriginalReact;

        private Rectangle buttonPorcentOriginalReact;
        private Rectangle buttonClearOriginalReact;
        private Rectangle buttonClearAllOriginalReact;
        private Rectangle buttonDellOriginalReact;
        private Rectangle buttonAboutXOriginalReact;
        private Rectangle buttonSquareOriginalReact;
        private Rectangle buttonRootOfTwoOriginalReact;
        private Rectangle buttonDivisionOriginalReact;
        private Rectangle button7OriginalReact;
        private Rectangle button8OriginalReact;
        private Rectangle button9OriginalReact;
        private Rectangle buttonXOriginalReact;
        private Rectangle button4OriginalReact;
        private Rectangle button5OriginalReact;
        private Rectangle button6OriginalReact;
        private Rectangle buttonSubtractOriginalReact;
        private Rectangle button1OriginalReact;
        private Rectangle button2OriginalReact;
        private Rectangle button3OriginalReact;
        private Rectangle buttonPlusOriginalReact;
        private Rectangle buttonInvertOriginalReact;
        private Rectangle button0OriginalReact;
        private Rectangle buttonSeparatorOriginalReact;
        private Rectangle buttonEqualOriginalReact;
        private Rectangle buttonMenuOrinalRect;
        private Rectangle lblHistoryOriginalRect;
        private Rectangle lblTypeOriginalRect;
        private Rectangle lblNameOriginalRect;

        private float buttonMenuFontSize;
        private float lblHistoryFontSize;
        private float lblTypeFontSize;
        private float lblNameFontSize;
        private float textBoxTxtInputFontSize;
        private float buttonMcFontSize;
        private float buttonMrFontSize;
        private float buttonMplusFontSize;
        private float buttonMminusFontSize;
        private float buttonMsFontSize;

        private float buttonPorcentFontSize;
        private float buttonClearFontSize;
        private float buttonClearAllFontSize;
        private float buttonDellFontSize;
        private float buttonAboutXFontSize;
        private float buttonSquareFontSize;
        private float buttonRootOfTwoFontSize;
        private float buttonDivisionFontSize;
        private float button7FontSize;
        private float button8FontSize;
        private float button9FontSize;
        private float buttonXFontSize;
        private float button4FontSize;
        private float button5FontSize;
        private float button6FontSize;
        private float buttonSubtractFontSize;
        private float button1FontSize;
        private float button2FontSize;
        private float button3FontSize;
        private float buttonPlusFontSize;
        private float buttonInvertFontSize;
        private float button0FontSize;
        private float buttonSeparatorFontSize;
        private float buttonEqualFontSize;

        private float fontScale = 1f;

        public Main()
        {
            InitializeComponent();

        }

        private void Main_Load(object sender, EventArgs e)
        {
            originalFormRect = new Rectangle(this.Location, this.Size);

            textBoxTxtInput = new Rectangle(txt_input.Location, txt_input.Size);
            buttonMcOriginalReact = new Rectangle(btn_MC.Location, btn_MC.Size);
            buttonMrOriginalReact = new Rectangle(btn_MR.Location, btn_MR.Size);
            buttonMplusOriginalReact = new Rectangle(btn_Mplus.Location, btn_Mplus.Size);
            buttonMminusOriginalReact = new Rectangle(btn_Mminus.Location, btn_Mminus.Size);

            buttonClearOriginalReact = new Rectangle(btn_clear.Location, btn_clear.Size);
            buttonClearAllOriginalReact = new Rectangle(btn_clearAll.Location, btn_clearAll.Size);
            buttonDellOriginalReact = new Rectangle(btn_ruber.Location, btn_ruber.Size);
            buttonAboutXOriginalReact = new Rectangle(btn_aboutX.Location, btn_aboutX.Size);
            buttonSquareOriginalReact = new Rectangle(btn_square.Location, btn_square.Size);
            buttonRootOfTwoOriginalReact = new Rectangle(btn_rootOfTwo.Location, btn_rootOfTwo.Size);
            buttonDivisionOriginalReact = new Rectangle(btn_division.Location, btn_division.Size);
            button7OriginalReact = new Rectangle(btn_7.Location, btn_7.Size);
            button8OriginalReact = new Rectangle(btn_8.Location, btn_8.Size);
            button9OriginalReact = new Rectangle(btn_9.Location, btn_9.Size);
            buttonXOriginalReact = new Rectangle(btn_multiply.Location, btn_multiply.Size);
            button4OriginalReact = new Rectangle(btn_4.Location, btn_4.Size);
            button5OriginalReact = new Rectangle(btn_5.Location, btn_5.Size);
            button6OriginalReact = new Rectangle(btn_6.Location, btn_6.Size);
            buttonSubtractOriginalReact = new Rectangle(btn_subtract.Location, btn_subtract.Size);
            button1OriginalReact = new Rectangle(btn_1.Location, btn_1.Size);
            button2OriginalReact = new Rectangle(btn_2.Location, btn_2.Size);
            button3OriginalReact = new Rectangle(btn_3.Location, btn_3.Size);
            buttonPlusOriginalReact = new Rectangle(btn_add.Location, btn_add.Size);
            buttonInvertOriginalReact = new Rectangle(btn_invert.Location, btn_invert.Size);
            button0OriginalReact = new Rectangle(btn_0.Location, btn_0.Size);
            buttonSeparatorOriginalReact = new Rectangle(btn_separator.Location, btn_separator.Size);
            buttonEqualOriginalReact = new Rectangle(btn_equal.Location, btn_equal.Size);
            buttonMenuOrinalRect = new Rectangle(btn_menu.Location, btn_menu.Size);
            lblHistoryOriginalRect = new Rectangle(lbl_history.Location, lbl_history.Size);
            lblTypeOriginalRect = new Rectangle(lbl_type.Location, lbl_type.Size);
            lblNameOriginalRect = new Rectangle(lbl_name.Location, lbl_name.Size);

            textBoxTxtInputFontSize = txt_input.Font.Size;
            buttonMcFontSize = btn_MC.Font.Size;
            buttonMrFontSize = btn_MR.Font.Size;
            buttonMplusFontSize = btn_Mplus.Font.Size;
            buttonMminusFontSize = btn_Mminus.Font.Size;
            buttonPorcentFontSize = btn_porcent.Font.Size;
            buttonClearFontSize = btn_clear.Font.Size;
            buttonClearAllFontSize = btn_clearAll.Font.Size;
            buttonDellFontSize = btn_ruber.Font.Size;
            buttonAboutXFontSize = btn_aboutX.Font.Size;
            buttonSquareFontSize = btn_square.Font.Size;
            buttonRootOfTwoFontSize = btn_rootOfTwo.Font.Size;
            buttonDivisionFontSize = btn_division.Font.Size;
            button7FontSize = btn_7.Font.Size;
            button8FontSize = btn_8.Font.Size;
            button9FontSize = btn_9.Font.Size;
            buttonXFontSize = btn_multiply.Font.Size;
            button4FontSize = btn_4.Font.Size;
            button5FontSize = btn_5.Font.Size;
            button6FontSize = btn_6.Font.Size;
            buttonSubtractFontSize = btn_subtract.Font.Size;
            button1FontSize = btn_1.Font.Size;
            button2FontSize = btn_2.Font.Size;
            button3FontSize = btn_3.Font.Size;
            buttonPlusFontSize = btn_add.Font.Size;
            buttonInvertFontSize = btn_invert.Font.Size;
            button0FontSize = btn_0.Font.Size;
            buttonSeparatorFontSize = btn_separator.Font.Size;
            buttonEqualFontSize = btn_equal.Font.Size;
            buttonMenuFontSize = btn_menu.Font.Size;
            lblHistoryFontSize = lbl_history.Font.Size;
            lblTypeFontSize = lbl_type.Font.Size;
            lblNameFontSize = lbl_name.Font.Size;

            resizeChildrenControls();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void resizeChildrenControls()
        {

            ResizeControl(buttonMenuOrinalRect, btn_menu, buttonMenuFontSize);
            ResizeControl(lblHistoryOriginalRect, lbl_history, lblHistoryFontSize);
            ResizeControl(lblTypeOriginalRect, lbl_type, lblTypeFontSize);
            ResizeControl(lblNameOriginalRect, lbl_name, lblNameFontSize);
            ResizeControl(textBoxTxtInput, txt_input, textBoxTxtInputFontSize);
            ResizeControl(buttonMcOriginalReact, btn_MC, buttonMcFontSize);
            ResizeControl(buttonMrOriginalReact, btn_MR, buttonMrFontSize);
            ResizeControl(buttonMplusOriginalReact, btn_Mplus, buttonMplusFontSize);
            ResizeControl(buttonMminusOriginalReact, btn_Mminus, buttonMminusFontSize);
            ResizeControl(buttonPorcentOriginalReact, btn_porcent, buttonPorcentFontSize);
            ResizeControl(buttonClearOriginalReact, btn_clear, buttonClearFontSize);
            ResizeControl(buttonClearAllOriginalReact, btn_clearAll, buttonClearAllFontSize);
            ResizeControl(buttonDellOriginalReact, btn_ruber, buttonDellFontSize);
            ResizeControl(buttonAboutXOriginalReact, btn_aboutX, buttonAboutXFontSize);
            ResizeControl(buttonSquareOriginalReact, btn_square, buttonSquareFontSize);
            ResizeControl(buttonRootOfTwoOriginalReact, btn_rootOfTwo, buttonRootOfTwoFontSize);
            ResizeControl(buttonDivisionOriginalReact, btn_division, buttonDivisionFontSize);
            ResizeControl(button7OriginalReact, btn_7, button7FontSize);
            ResizeControl(button8OriginalReact, btn_8, button8FontSize);
            ResizeControl(button9OriginalReact, btn_9, button9FontSize);
            ResizeControl(buttonXOriginalReact, btn_multiply, buttonXFontSize);
            ResizeControl(button4OriginalReact, btn_4, button4FontSize);
            ResizeControl(button5OriginalReact, btn_5, button5FontSize);
            ResizeControl(button6OriginalReact, btn_6, button6FontSize);
            ResizeControl(buttonSubtractOriginalReact, btn_subtract, buttonSubtractFontSize);
            ResizeControl(button1OriginalReact, btn_1, button1FontSize);
            ResizeControl(button2OriginalReact, btn_2, button2FontSize);
            ResizeControl(button3OriginalReact, btn_3, button3FontSize);
            ResizeControl(buttonPlusOriginalReact, btn_add, buttonPlusFontSize);
            ResizeControl(buttonInvertOriginalReact, btn_invert,buttonInvertFontSize);
            ResizeControl(button0OriginalReact, btn_0,button0FontSize);
            ResizeControl(buttonSeparatorOriginalReact, btn_separator,buttonSeparatorFontSize);
            ResizeControl(buttonEqualOriginalReact, btn_equal,buttonEqualFontSize);
        }


        private void ResizeControl(Rectangle originalControlRect, Control control, float originalFontSize)
        {
            
            float xRatio = (float)this.ClientRectangle.Width / (float)originalFormRect.Width;
            float yRatio = (float)this.ClientRectangle.Height / (float)originalFormRect.Height;

            float newX = originalControlRect.Location.X * xRatio;
            float newY = originalControlRect.Location.Y * yRatio;

            control.Location = new Point((int)newX, (int)newY);
            control.Width = (int)(originalControlRect.Width * xRatio);
            control.Height = (int)(originalControlRect.Height * yRatio);

            float ratio = xRatio;
            if (xRatio >= yRatio)
                ratio = yRatio;

            float newFontSize = originalFontSize * ratio * fontScale;
            Font newFont = new Font(control.Font.FontFamily, newFontSize);
            control.Font = newFont;
        }


        Double memory = 0;
        Double resultValue = 0;
        String value = "";
        String operationPerformed = "";
        bool isOperationPerformed = false;


        private void number_click(object sender, EventArgs e)
        {
            if ((txt_input.Text == "0") || (isOperationPerformed))
                txt_input.Clear();

            isOperationPerformed = false;
            Button buttonaActivated = (Button)sender;
            if (txt_input.Text.Length <= 14)
            {
                if (buttonaActivated.Text == ".")
                {
                    if (!txt_input.Text.Contains("."))
                        txt_input.Text += buttonaActivated.Text;
                }
                else
                    txt_input.Text += buttonaActivated.Text;
            }

        }

        private void operador_click(object sender, EventArgs e)
        {
            Button buttonaActivated = (Button)sender;

            if ((buttonaActivated.Name == "btn_aboutX"))
            {
                value = txt_input.Text;
                operationPerformed = buttonaActivated.Text;
                
                btn_equal.PerformClick();
                lbl_history.Text = "1 / " + value;
                isOperationPerformed = true;
            }
            else if (resultValue != 0)
            {
                string aux = lbl_history.Text.Substring(lbl_history.Text.Length - 1, 1);
                if(Regex.IsMatch(aux, @"^\d+$") || (isOperationPerformed == false))
                    btn_equal.PerformClick();
                operationPerformed = buttonaActivated.Text;
                lbl_history.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = buttonaActivated.Text;
                resultValue = Double.Parse(txt_input.Text);
                lbl_history.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            txt_input.Text = "0";
        }

        private void clear_all_click(object sender, EventArgs e)
        {
            txt_input.Text = "0";
            lbl_history.Text = "0";
            resultValue = 0;
        }
        private void btn_ruber_Click(object sender, EventArgs e)
        {
           
            if ((txt_input.Text != "0") && (txt_input.Text != ""))
                txt_input.Text = txt_input.Text.Remove(txt_input.Text.Length - 1);
            if (txt_input.Text == "")
                txt_input.Text = "0";
        }

        private void commun_operation()
        {

        }


        private void equal_click(object sender, EventArgs e)
        {
            lbl_history.Text += " " + txt_input.Text + "=  ";
            switch (operationPerformed)
            {
                case "+":
                    txt_input.Text = (resultValue + Double.Parse(txt_input.Text)).ToString();
                    break;
                case "-":
                    txt_input.Text = (resultValue - Double.Parse(txt_input.Text)).ToString();
                    break;
                case "X":
                    txt_input.Text = (resultValue * Double.Parse(txt_input.Text)).ToString();
                    break;
                case "/":
                    txt_input.Text = (resultValue / Double.Parse(txt_input.Text)).ToString();
                    break;
                case "1/X":
                    txt_input.Text = (1 / Double.Parse(txt_input.Text)).ToString();
                    break;
                default:
                    break;
            }
            isOperationPerformed = false;
            resultValue = Double.Parse(txt_input.Text);
            
        }

        private void inverse_click(object sender, EventArgs e)
        {
            txt_input.Text = (Double.Parse(txt_input.Text) * -1.0).ToString();
        }

        private void btn_Mplus_Click(object sender, EventArgs e)
        {
            memory = memory + Double.Parse(txt_input.Text);
            isOperationPerformed = true;
        }

        private void btn_Mminus_Click(object sender, EventArgs e)
        {
            memory = memory - Double.Parse(txt_input.Text);
            isOperationPerformed = true;
        }

        private void btn_MR_Click(object sender, EventArgs e)
        {
            txt_input.Text = memory.ToString();
        }
    }
}