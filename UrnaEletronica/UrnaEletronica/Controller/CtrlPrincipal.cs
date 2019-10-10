using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrnaEletronica.Interface;
using UrnaEletronica.View;

namespace UrnaEletronica.Controller
{
    public class CtrlPrincipal
    {
        public IPrincipal PrincipalView { get; set; }

        public CtrlPrincipal()
        {
            PrincipalView = new FrmPrincipal();

            this.DelegarEventos();

        }
        /*
         implementações a serem feitas
         colocar pra ler arquivo de teste criptografado
         com nome e numero do candidato
         salvar num arquivo de texto o voto de cada candidato criptografado
         gravar a finalização do arquivo e depois validar a legitimidade do arquivo
         com validação criptograda dos dados
         com a criptografia da criptografia

            criar programa que gerencie a mesma de forma que a libere por comando (tipo wcf)
            sendo que podemos configurar por entrada simples (botão abrir por exemplo)
            ou pela titulo de eleitor ou algum outro documento que comprove identidade unica
             
             
             
             
             
             */

        private void DelegarEventos()
        {
            // iniciar eventos dos botões

            this.PrincipalView.Btn0.Click += Btn0_Click;
            this.PrincipalView.Btn1.Click += Btn0_Click;
            this.PrincipalView.Btn2.Click += Btn0_Click;
            this.PrincipalView.Btn3.Click += Btn0_Click;
            this.PrincipalView.Btn4.Click += Btn0_Click;
            this.PrincipalView.Btn5.Click += Btn0_Click;
            this.PrincipalView.Btn6.Click += Btn0_Click;
            this.PrincipalView.Btn7.Click += Btn0_Click;
            this.PrincipalView.Btn8.Click += Btn0_Click;
            this.PrincipalView.Btn9.Click += Btn0_Click;

            this.PrincipalView.BtnBranco.Click += Btn0_Click;
            this.PrincipalView.BtnCorrige.Click += Btn0_Click;
            this.PrincipalView.BtnConfirma.Click += Btn0_Click;

        }

        private void Btn0_Click(object sender, EventArgs e)
        {


        }
    }
}
