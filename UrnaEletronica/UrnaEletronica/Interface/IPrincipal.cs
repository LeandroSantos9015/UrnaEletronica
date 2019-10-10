using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnaEletronica.Interface
{
    public interface IPrincipal
    {
        Form PrincipalView { get; }

        Button Btn1 { get; }
        Button Btn2 { get; }
        Button Btn3 { get; }
        Button Btn4 { get; }
        Button Btn5 { get; }
        Button Btn6 { get; }
        Button Btn7 { get; }
        Button Btn8 { get; }
        Button Btn9 { get; }
        Button Btn0 { get; }

        Button BtnBranco { get; }
        Button BtnCorrige { get; }
        Button BtnConfirma { get; }



    }
}
