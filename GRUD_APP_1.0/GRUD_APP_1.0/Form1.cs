using MySql.Data.MySqlClient;

namespace GRUD_APP_1._0
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            listViewBusca.View = View.Details;
            listViewBusca.LabelEdit = true;
            listViewBusca.AllowColumnReorder = true;
            listViewBusca.FullRowSelect = true;
            listViewBusca.GridLines = true;

            listViewBusca.Columns.Add("Id", 30, HorizontalAlignment.Left);
            listViewBusca.Columns.Add("Nome", 100, HorizontalAlignment.Left);
            listViewBusca.Columns.Add("Sexo", 30, HorizontalAlignment.Left);
            listViewBusca.Columns.Add("Data", 100, HorizontalAlignment.Left);
            listViewBusca.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
            listViewBusca.Columns.Add("Codcontato", 100, HorizontalAlignment.Left);

        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciando a conexão com o MySql
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    cnn.ConnectionString = "datasource=localhost;username=root;password= ;database= db_cadastro";
                    cnn.Open();
                    // Variavel  para adcionar os textos da caixa de texto apos clicar no botão salvar.
                    string sql = "INSERT INTO `db_cadastro`.`contato` (`nome`, `sexo`, `data`, `cidade`, `codcontato`)  VALUES ('"+textNome.Text+"', '"+textSexo.Text+"', '"+textData.Text+"', '"+textCidade.Text+"', '"+textCodcontato.Text+"')";
                    MySqlCommand comando = new MySqlCommand(sql, cnn);
                    // Labal de verificação com a conexão
                    labelConfirmar.Text = "Conexão com MySQL com sucesso!";
                    comando.ExecuteReader();

                    MessageBox.Show("Contato salvo com sucesso !");
                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // iniciando conexão com o MySql
                using (MySqlConnection cnn = new MySqlConnection())
                {

                    cnn.ConnectionString = "datasource=localhost;username=root;password= ;database= db_cadastro";
                    cnn.Open();
                    // Variavel de busca:
                    string busca = "SELECT * FROM `contato` ORDER by `cidade`, `sexo` DESC";
                    MySqlCommand comando = new MySqlCommand(busca, cnn);
                    labelConfirmar.Text = "Conexão com MySQL com sucesso!";
                    comando.ExecuteReader();

                    MessageBox.Show("Busca feita com sucesso !");
                    using MySqlDataReader reader = comando.ExecuteReader();

                    listViewBusca.Items.Clear();

                    while (reader.Read()) 
                    {
                        string[] row = 
                            {
                            reader.GetString(0),
                            reader.GetString(1),
                            reader.GetString(2),
                            reader.GetString(3),
                            reader.GetString(4),
                            reader.GetString(5),

                        };

                        var linha_listview = new ListViewItem(row);

                        listViewBusca.Items.Add(linha_listview);

                    }

                    cnn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void listViewBusca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Iniciando a conexão com o MySql
                using (MySqlConnection cnn = new MySqlConnection())
                {
                    cnn.ConnectionString = "datasource=localhost;username=root;password= ;database= db_cadastro";
                    cnn.Open();
                    // Variavel para deletar .
                    string sql = "DELETE FROM `db_cadastro`.`contato` WHERE (`id` = '"+ textDeleteId +"');";
                    MySqlCommand comando = new MySqlCommand(sql, cnn);
                    // Labal de verificação com a conexão
                    labelConfirmar.Text = "Conexão com MySQL com sucesso!";
                    comando.ExecuteReader();

                    // mensagem de comando deletado
                    MessageBox.Show("Deletado com sucesso !");

                    cnn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}