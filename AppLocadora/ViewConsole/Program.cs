using System;
using Classes.DAO;
using Classes.Conexao;
using Interfaces.Operation;
using Classes.Entidades;
using System.Collections.ObjectModel;

namespace ViewConsole
{
    class Program
    {
        static void Main(string[] args)
        {         
            void BeneficiarioListarTudo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Beneficiario> BeneficiarioIDAO = new BeneficiarioDAO(con);

                    Collection<Beneficiario> result = BeneficiarioIDAO.ListarTudo();

                    foreach (Beneficiario b in result)
                    {
                        Console.WriteLine("ID:{0} , CNPJ:{1} , APELIDO:{2} , RAZÃO:{3}",
                            b.BENEFICIARIO_ID,
                            b.BENEFICIARIO_CNPJCPF,
                            b.BENEFICIARIO_NOMEFAN,
                            b.BENEFICIARIO_RAZAOSOC);
                    }
                }
            }           

            void BeneficiarioListarPorCodigo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Beneficiario> BeneficiarioIDAO = new BeneficiarioDAO(con);

                    Beneficiario b = BeneficiarioIDAO.LocalizarPorCodigo(11);

                    if (b == null)
                    {
                        Console.WriteLine("Não existe!");
                    }
                    else
                    {
                        Console.WriteLine("ID:{0} , CNPJ:{1} , APELIDO:{2} , RAZÃO:{3}",
                        b.BENEFICIARIO_ID,
                        b.BENEFICIARIO_CNPJCPF,
                        b.BENEFICIARIO_NOMEFAN,
                        b.BENEFICIARIO_RAZAOSOC);
                    }
                }
            }

            void BeneficiarioInserir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Beneficiario> BeneficiarioIDAO = new BeneficiarioDAO(con);

                    Beneficiario b = new Beneficiario();
                    //b.BENEFICIARIO_ID,
                    b.BENEFICIARIO_CNPJCPF = "47508411081059";
                    b.BENEFICIARIO_NOMEFAN = "SUPERMERCADO EXTRA";
                    b.BENEFICIARIO_RAZAOSOC = "CIA BRASILEIRA DE DISTRIBUIÇÃO";

                    BeneficiarioIDAO.Inserir(b);

                }
            }

            void BeneficiarioExcluir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Beneficiario> BeneficiarioIDAO = new BeneficiarioDAO(con);

                    Beneficiario b = new Beneficiario();
                    b.BENEFICIARIO_ID = 13;
                    b.BENEFICIARIO_CNPJCPF = "47508411081059";
                    b.BENEFICIARIO_NOMEFAN = "SUPERMERCADO EXTRA";
                    b.BENEFICIARIO_RAZAOSOC = "CIA BRASILEIRA DE DISTRIBUIÇÃO";

                    BeneficiarioIDAO.Remover(b);

                }
            }

            void BeneficiarioAtualizar()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Beneficiario> BeneficiarioIDAO = new BeneficiarioDAO(con);

                    Beneficiario b = new Beneficiario();
                    b.BENEFICIARIO_ID = 11;
                    b.BENEFICIARIO_CNPJCPF = "47508411081059";
                    b.BENEFICIARIO_NOMEFAN = "SUPERMERCADO EXTRAS";
                    b.BENEFICIARIO_RAZAOSOC = "CIA BRASILEIRA DE DISTRIBUIÇÃO";

                    BeneficiarioIDAO.Atualizar(b);

                }
            }

            void PagadorListarTudo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Pagador> Tabela = new PagadorDAO(con);

                    Collection<Pagador> result = Tabela.ListarTudo();

                    foreach (var v in result)
                    {
                        Console.WriteLine("ID:{0} , CNPJ:{1} , NOME:{2}",
                            v.PAGADOR_ID,
                            v.PAGADOR_CNPJCPF,
                            v.PAGADOR_NOME);
                    }
                }
            }

            void PagadorListarPorCodigo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Pagador> Tabela = new PagadorDAO(con);

                    Pagador b = Tabela.LocalizarPorCodigo(22);

                    if (b == null)
                    {
                        Console.WriteLine("Não existe!");
                    }
                    else
                    {
                        Console.WriteLine("ID:{0} , CPF:{1} , NOME:{2}",
                            b.PAGADOR_ID,
                            b.PAGADOR_CNPJCPF,
                            b.PAGADOR_NOME);
                    }
                }
            }

            void PagadorInserir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Pagador> Tabela = new PagadorDAO(con);

                    Pagador b = new Pagador();
                    b.PAGADOR_CNPJCPF = "07675797477";
                    b.PAGADOR_NOME = "EVERALDO JOSÉ COSTA DE ALMEIDA";

                    Tabela.Inserir(b);

                }
            }

            void PagadorExcluir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Pagador> Tabela = new PagadorDAO(con);

                    Pagador b = new Pagador();
                    b.PAGADOR_ID = 1;

                    Tabela.Remover(b);

                }
            }

            void PagadorAtualizar()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Pagador> Tabela = new PagadorDAO(con);

                    Pagador b = new Pagador();
                    b.PAGADOR_ID = 1;
                    b.PAGADOR_CNPJCPF = "07675797477";
                    b.PAGADOR_NOME = "EVERALDO JOSE COSTA DE ALMEIDA";

                    Tabela.Atualizar(b);

                }
            }

            void FormaPagListarTudo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Forma_Pag> Tabela = new Forma_PagDAO(con);

                    Collection<Forma_Pag> result = Tabela.ListarTudo();

                    foreach (var v in result)
                    {
                        Console.WriteLine("ID:{0} , DESCRIÇÃO:{1}",
                            v.FORMA_PAG_ID,
                            v.FORMA_PAG_DESCRICAO);
                    }
                }
            }

            void FormaPagListarPorCodigo()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Forma_Pag> Tabela = new Forma_PagDAO(con);

                    Forma_Pag b = Tabela.LocalizarPorCodigo(2);

                    if (b == null)
                    {
                        Console.WriteLine("Não existe!");
                    }
                    else
                    {
                        Console.WriteLine("ID:{0} , DESCRIÇÃO:{1}",
                            b.FORMA_PAG_ID,
                            b.FORMA_PAG_DESCRICAO);
                    }
                }
            }

            void FormaPagInserir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Forma_Pag> Tabela = new Forma_PagDAO(con);

                    Forma_Pag b = new Forma_Pag();
                    b.FORMA_PAG_DESCRICAO = "DINHEIRO";

                    Tabela.Inserir(b);

                }
            }

            void FormaPagExcluir()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Forma_Pag> Tabela = new Forma_PagDAO(con);

                    Forma_Pag b = new Forma_Pag();
                    b.FORMA_PAG_ID = 1;

                    Tabela.Remover(b);
                }
            }

            void FormaPagAtualizar()
            {
                using (Connection con = new Connection())
                {
                    con.Abrir();
                    IDAO<Forma_Pag> Tabela = new Forma_PagDAO(con);

                    Forma_Pag b = new Forma_Pag();
                    b.FORMA_PAG_ID = 1;
                    b.FORMA_PAG_DESCRICAO = "DINHEIROS";

                    Tabela.Atualizar(b);
                }
            }

            FormaPagListarPorCodigo();
            Console.ReadKey();
        }
    }
}
