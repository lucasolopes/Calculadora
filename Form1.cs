using System.Data;
using System.Dynamic;
using System.Text;
using System.Text.RegularExpressions;

namespace Calculadora
{
    public partial class Main : Form
    {
        private Rectangle originalFormRect;

        private Rectangle textBoxTxtInput;


        private Rectangle buttonClearOriginalReact;
        private Rectangle buttonClearAllOriginalReact;
        private Rectangle buttonDellOriginalReact;

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

        private Rectangle button0OriginalReact;
        private Rectangle buttonSeparatorOriginalReact;
        private Rectangle buttonEqualOriginalReact;

        private Rectangle lblHistoryOriginalRect;

        private Rectangle lblNameOriginalRect;


        private float lblHistoryFontSize;

        private float lblNameFontSize;
        private float textBoxTxtInputFontSize;



        private float buttonClearFontSize;
        private float buttonClearAllFontSize;
        private float buttonDellFontSize;

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
            buttonClearOriginalReact = new Rectangle(btn_clear.Location, btn_clear.Size);
            buttonClearAllOriginalReact = new Rectangle(btn_clearAll.Location, btn_clearAll.Size);
            buttonDellOriginalReact = new Rectangle(btn_ruber.Location, btn_ruber.Size);

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

            button0OriginalReact = new Rectangle(btn_0.Location, btn_0.Size);
            buttonSeparatorOriginalReact = new Rectangle(btn_separator.Location, btn_separator.Size);
            buttonEqualOriginalReact = new Rectangle(btn_equal.Location, btn_equal.Size);

            lblHistoryOriginalRect = new Rectangle(lbl_history.Location, lbl_history.Size);

            lblNameOriginalRect = new Rectangle(lbl_name.Location, lbl_name.Size);

            textBoxTxtInputFontSize = txt_input.Font.Size;

            buttonClearFontSize = btn_clear.Font.Size;
            buttonClearAllFontSize = btn_clearAll.Font.Size;
            buttonDellFontSize = btn_ruber.Font.Size;

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

            button0FontSize = btn_0.Font.Size;
            buttonSeparatorFontSize = btn_separator.Font.Size;
            buttonEqualFontSize = btn_equal.Font.Size;

            lblHistoryFontSize = lbl_history.Font.Size;

            lblNameFontSize = lbl_name.Font.Size;

            resizeChildrenControls();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            resizeChildrenControls();
        }

        private void resizeChildrenControls()
        {
            

            ResizeControl(lblHistoryOriginalRect, lbl_history, lblHistoryFontSize);

            ResizeControl(lblNameOriginalRect, lbl_name, lblNameFontSize);
            ResizeControl(textBoxTxtInput, txt_input, textBoxTxtInputFontSize);


            ResizeControl(buttonClearOriginalReact, btn_clear, buttonClearFontSize);
            ResizeControl(buttonClearAllOriginalReact, btn_clearAll, buttonClearAllFontSize);
            ResizeControl(buttonDellOriginalReact, btn_ruber, buttonDellFontSize);

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

        

        ExpressaoNumerica expressao = new ExpressaoNumerica();



        private void limparInput()
        {
            txt_input.Text = "0";
            clearInput = true;
        }

        private void limparHistorico()
        {
            lbl_history.Text = "";

        }
        private void limparTudo()
        {
            limparInput();
            limparHistorico();
            expressao.ResetarValores();
            clearInput = true;
        }


        private void clear_click(object sender, EventArgs e)
        {
            limparInput();

        }

        private void clear_all_click(object sender, EventArgs e)
        {
            limparTudo();

        }


        string inFocus = "numero";

        bool clearInput = true;


        private void number_click(object sender, EventArgs e)
        {
            Button buttonaActivated = (Button)sender;
            if (clearInput)
                txt_input.Clear();
            
            txt_input.Text += buttonaActivated.Text;
            inFocus = "numero";
            clearInput = false;
        }

        private void operador_click(object sender, EventArgs e)
        {
            Button buttonaActivated = (Button) sender;
            if (expressao.SegundoValor != null && inFocus == "numero" )
            {
                expressao.SegundoValor = txt_input.Text;
                inFocus = "operador";
                btn_equal.PerformClick();
            }

        
            expressao.PrimeiroValor =  txt_input.Text;
            expressao.Operador = buttonaActivated.Text;
            lbl_history.Text = expressao.PrimeiroValor + expressao.Operador;
            if (inFocus != "operador")
                expressao.SegundoValor = expressao.PrimeiroValor;
            
            clearInput = true;

            inFocus = "operador";
        }

        private void equal_click(object sender, EventArgs e)
        {

            if (inFocus == "numero" && expressao.Operador != null)
            {
                expressao.SegundoValor = txt_input.Text;
                lbl_history.Text += expressao.SegundoValor + " =";
            }
            else if (inFocus == "igual" && expressao.Operador != null )
            {
                expressao.PrimeiroValor = txt_input.Text;
                lbl_history.Text = expressao.PrimeiroValor + expressao.Operador + expressao.SegundoValor + " =";
               
            }else if(expressao.Operador == null)
            {
                lbl_history.Text = txt_input.Text + " =";
                expressao.PrimeiroValor = txt_input.Text;
            }

            if (expressao.Operador != null)
                txt_input.Text = Math.Round( Convert.ToDouble(expressao.calcular()), 7).ToString();


            inFocus = "igual";
            clearInput = true;
        }


        private void btn_separator_Click(object sender, EventArgs e)
        {
            if (!txt_input.Text.Contains(","))
                txt_input.Text += ",";
                clearInput = false;
        }

        private void btn_ruber_Click(object sender, EventArgs e)
        {
            txt_input.Text = txt_input.Text.Remove(txt_input.Text.Length - 1, 1);
            if (txt_input.Text.Length == 0)
            {
                txt_input.Text = "0";
                
                clearInput = true;
            }
            inFocus = "numero";
        }


    }
}