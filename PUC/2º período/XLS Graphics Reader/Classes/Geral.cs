using Microsoft.Office.Interop.Excel;
using System;

namespace TI_FSI.Classes
{
    public class Geral : Tabela
    {
        private bool _firstload;

        public Geral(Form1 frm) : base(frm)
        {
            this.form = frm;
            this.form.Send = this.form.charGeral;
        }

        public override void GetInformations()
        {
            if (!_firstload)
            {
                this.relatorio.Add(new DADOS("Comida", Comida.QuantTotal[1]));
                this.relatorio.Add(new DADOS("Brinquedo", Brinquedo.QuantTotal[2]));
                this.relatorio.Add(new DADOS("Roupa", Roupas.QuantTotal[0]));
                _firstload = true;
            }
            else
            {
                this.form.Send = this.form.charGeralRegis;
                this.relatorio.Add(new DADOS("Comida", Comida.NumlinComida));
                this.relatorio.Add(new DADOS("Brinquedo", Brinquedo.NumlinBrinq));
                this.relatorio.Add(new DADOS("Roupa", Roupas.NumlinRoupa));
            }
        }

    }
}


