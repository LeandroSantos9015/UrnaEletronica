using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnaEletronica.Interface;

namespace UrnaEletronica.View
{
    public partial class FrmPrincipal : Form, IPrincipal
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public Form PrincipalView { get { return this; } }

        public Button Btn1 { get { return this.btn1; } }

        public Button Btn2 { get { return this.btn2; } }

        public Button Btn3 { get { return this.btn3; } }

        public Button Btn4 { get { return this.btn4; } }

        public Button Btn5 { get { return this.btn5; } }

        public Button Btn6 { get { return this.btn6; } }

        public Button Btn7 { get { return this.btn7; } }

        public Button Btn8 { get { return this.btn8; } }

        public Button Btn9 { get { return this.btn9; } }

        public Button Btn0 { get { return this.btn0; } }

        public Button BtnBranco { get { return this.btnBranco; } }

        public Button BtnCorrige { get { return this.btnCorrige; } }

        public Button BtnConfirma { get { return this.btnConfirma; } }
    }
}
