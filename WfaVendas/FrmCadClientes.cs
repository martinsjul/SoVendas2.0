using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendas
{
    public partial class FrmCadClientes : Form
    {
        bool incluir = false;
        bool alterar = false;
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'lP2DataSet.pc_clientes'. Você pode movê-la ou removê-la conforme necessário.
            this.pc_clientesTableAdapter.Fill(this.lP2DataSet.pc_clientes);

        }

        private void button8_Click(object sender, EventArgs e) //Botâo de sair
        {
            Close();
        }
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(true);
            HabilitaBotoes(false);
            LimpaCampos();
            incluir = true;
            txtNome.Focus();
        }

        private void HabilitaBotoes(bool hab)
        {
            foreach (Control btn in Controls)
            {
                if (btn is Button)
                {
                    btn.Enabled = hab;
                    if (btn.Name == "btnGravar" || btn.Name == "btnCancelar")
                    {
                        btn.Enabled = !hab;
                    }
                }
            }
        }

        private void HabilitaCampos(bool hab)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is DateTimePicker)
                {
                    item.Enabled = hab;
                }
            }
        }

        private void LimpaCampos()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Clear();
                }
                else if (item is MaskedTextBox)
                {
                    ((MaskedTextBox)item).Clear();
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }


            }
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            try 
            {
                if (incluir)
                {
                    pc_clientesTableAdapter.Insert(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, mskUF.Text, mskCEP.Text, mskTelefone.Text, dtpDatanasc.Value);
                    MessageBox.Show("Incluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
  
                FrmCadClientes_Load(null, null);
                btnCancelar_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: \n" + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            HabilitaBotoes(true);
            LimpaCampos();
            HabilitaCampos(false);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                HabilitaBotoes(false);
                HabilitaCampos(true);
                txtCodcli.Enabled = false;
                txtCodcli.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCEP.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskUF.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDatanasc.Value = Convert.ToDateTime(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
                txtNome.Focus();
            }
        }



        private void btnListar_Click(object sender, EventArgs e)
        {

        }
        private void telefoneMaskedTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClientes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone" || this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "Telefone2")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5) + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }
                }
            }
            else if (this.dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "CEP")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }
                }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtNome.Enabled == false)
            {
                txtNome.Enabled = true;
                txtNome.Focus();
                HabilitaBotoes(false);
                btnPesquisar.Enabled = true;
                btnGravar.Enabled = false;
                btnCancelar.Enabled = false;
                MessageBox.Show(null, "Digite o nome desejado ou" + "\nparte dele", "Pesquisar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                pc_clientesTableAdapter.FillByNome(this.lP2DataSet.pc_clientes,
                    "%" + txtNome.Text + "%");
                btnCancelar_Click(null, null);
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção:", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                      MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(Convert.ToInt32(
                            dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        FrmCadClientes_Load(null, null);
                        MessageBox.Show(null,"Apagado com sucesso!", "Exclusão",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show(null, "Selecione um cliente primeiro!", "Erro ao excluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Sair?", "Atenção: ",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
