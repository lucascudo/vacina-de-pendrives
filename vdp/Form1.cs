using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace vdp
{
    public partial class Main : Form
    {
        //MINHA FUNCOES
        private bool avisaFormatar()
        {
            DialogResult comfirm = MessageBox.Show(
                "Este processo irá formatar seu pendrive, deseja continuar?"
                , "Confirmação"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation);
            if (comfirm.ToString().ToUpper() == "YES")
                return true;
            else
                return false;
        }
        private void formatar(string unidade) 
        {
            Process p = System.Diagnostics.Process.Start("format", unidade+" /fs:fat32 /q /y");
            p.WaitForExit();
        }
        private void chkdsk(string unidade) 
        {
            Process p = System.Diagnostics.Process.Start("chkdsk", unidade+" /v /f /r");
            p.WaitForExit();
        }
        private void vacinar(string unidade)
        {
            Process p = System.Diagnostics.Process.Start("convert", unidade + " /fs:ntfs");
            p.WaitForExit();
            System.IO.Directory.CreateDirectory(unidade+"\\arquivos");
            p = System.Diagnostics.Process.Start("cacls", unidade + "\\arquivos /e /p Todos:F");
            p.WaitForExit();
            p = System.Diagnostics.Process.Start("cacls", unidade + " /e /p Todos:R");
            p.WaitForExit();
        }
        //FIM DAS MINHAS FUNCOES

        public Main()
        {
            InitializeComponent();
        }

        private void linkRA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://lucas.redeaberta.com.br/");
        }

        private void buttonVacinar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            diskSelect.ShowDialog();
            progressBar1.Value += 10;
            if (this.avisaFormatar())
            {
                string unidade = diskSelect.SelectedPath.ToString() + " ";
                if (unidade.Trim() != "")
                {
                    unidade = unidade.Substring(0, 2);
                    if (unidade.Substring(1, 1) == ":")
                    {
                        //formatando
                        this.formatar(unidade);
                        progressBar1.Value += 25;
                        this.Refresh();
                        //checando
                        this.chkdsk(unidade);
                        progressBar1.Value += 25;
                        this.Refresh();
                        //aplicando vacina
                        this.vacinar(unidade);
                        progressBar1.Value += 40;
                        this.Refresh();
                        MessageBox.Show("UNIDADE " + unidade + " VACINADA COM SUCESSO!", "SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Você deve selecionar um pendrive"
                            , "ERRO"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                }
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            this.Refresh();
        }

        private void buttonScanDisk_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            diskSelect.ShowDialog();
            progressBar1.Value += 10;
            string unidade = diskSelect.SelectedPath.ToString() + " ";
            if (unidade.Trim() != "")
            {
                unidade = unidade.Substring(0, 2);
                if (unidade.Substring(1, 1) == ":")
                {
                    //checando
                    progressBar1.Value += 20;
                    this.Refresh();
                    this.chkdsk(unidade);
                    progressBar1.Value += 70;
                    MessageBox.Show("O SCANDISK FOI EXECUTADO NA UNIDADE " + unidade, "SUCESSO");
                }
                else
                {
                    MessageBox.Show(
                        "Você deve selecionar um pendrive"
                        , "ERRO"
                        , MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                }
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            this.Refresh();
        }

        private void buttonDisableAR_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value += 50;
            this.Refresh();
            System.Diagnostics.Process.Start(
                "regedit.exe"
                , "/s "+System.IO.Directory.GetCurrentDirectory().ToString()+"\\disable_ar.reg");
            progressBar1.Value += 50;
            MessageBox.Show("Seu computador foi vacinado contra vírus de AutoRun", "SUCESSO");
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            this.Refresh();
        }

        private void buttonEnableAR_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            progressBar1.Value += 50;
            this.Refresh();
            System.Diagnostics.Process.Start(
                "regedit.exe"
                , "/s " + System.IO.Directory.GetCurrentDirectory().ToString() + "\\enable_ar.reg");
            progressBar1.Value += 50;
            MessageBox.Show("A vacina foi removida de seu computador", "SUCESSO");
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            this.Refresh();
        }

        private void buttonFormatar_Click(object sender, EventArgs e)
        {
            progressBar1.Visible = true;
            diskSelect.ShowDialog();
            progressBar1.Value += 10;
            if (this.avisaFormatar())
            {
                string unidade = diskSelect.SelectedPath.ToString() + " ";
                if (unidade.Trim() != "")
                {
                    unidade = unidade.Substring(0, 2);
                    if (unidade.Substring(1, 1) == ":")
                    {
                        //Formatando
                        progressBar1.Value += 20;
                        this.Refresh();
                        this.formatar(unidade);
                        progressBar1.Value += 70;
                        MessageBox.Show("A UNIDADE " + unidade + " FOI FORMATADA COM SUCESSO", "SUCESSO");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Você deve selecionar um pendrive"
                            , "ERRO"
                            , MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                    }
                }
            }
            progressBar1.Value = 0;
            progressBar1.Visible = false;
            this.Refresh();
        }
    }
}
