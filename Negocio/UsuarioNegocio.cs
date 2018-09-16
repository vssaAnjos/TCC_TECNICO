using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AcessoBD;
using ObjetoTransferencia;
using System.Data;


public class UsuarioNegocio
{

    AcessoBDSql acessoBDSql = new AcessoBDSql();

    // INSERIR CADASTRO Cod_cadastro
    public string CadastroInserir(Cadastro usuario) // no paratense é a tabela do usuario ou a classe do obj_trans
    {
        try
        {
            //Limpeza dos parâmetros
            acessoBDSql.LimparParametros();

            //Adicionar parâmetros

            acessoBDSql.AdicionarParametros("@Usuario", usuario.Nome_Usuario);
            acessoBDSql.AdicionarParametros("@Sexo", usuario.Sexo);
            acessoBDSql.AdicionarParametros("@Idade", usuario.Idade);
            acessoBDSql.AdicionarParametros("@Senha", usuario.Senha);
            //Acesso ao método do Stored Procedure



            string nome_Usuario = acessoBDSql.ManipulaDados(CommandType.StoredProcedure, "CadastroInserir").ToString();
         
            return nome_Usuario;

        }

        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    // INSERIR teste cod_teste/ resultado
    public string TesteInserir(PerfilUsuario teste) // no paratense é a tabela do usuario ou a classe do obj_trans
    {
        try
        {
            //Limpeza dos parâmetros
            acessoBDSql.LimparParametros();

            //Adicionar parâmetros

            acessoBDSql.AdicionarParametros("@Resultado", teste.resultado);


            //Acesso ao método do Stored Procedure
            //ManipularDados?


            string resultado = acessoBDSql.ManipulaDados(CommandType.StoredProcedure, "TesteInserir").ToString();

            return resultado;

        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    // INSERIR Progresso
    public string ProgressoInserir(PerfilUsuario progresso) // no paratense é a tabela do usuario ou a classe do obj_trans
    {
        try
        {
            //Limpeza dos parâmetros
            acessoBDSql.LimparParametros();

            //Adicionar parâmetros
            // acessoBDSql.AdicionarParametros("@Cod_progresso", progresso.Cod_Progresso);
            // acessoBDSql.AdicionarParametros("@Cod_teste", progresso.cod_teste);
            acessoBDSql.AdicionarParametros("@licao_usuario", progresso.licao_usuario);
            acessoBDSql.AdicionarParametros("@Modulo_usuario", progresso.modulo_usuario);
            acessoBDSql.AdicionarParametros("@progre_usuario", progresso.progresso_usuario);




            //Acesso ao método do Stored Procedure
            //ManipularDados?



            string progresso_usuario = acessoBDSql.ManipulaDados(CommandType.StoredProcedure, "ProgressoInserir").ToString();

            return progresso_usuario;

        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }
    // EXLCUIR CADASTRO
    public string ExcluirCadastro(Cadastro cadastro)
    {
        try
        {
            acessoBDSql.LimparParametros();

            acessoBDSql.AdicionarParametros("@Cod_cadastro", cadastro);
            acessoBDSql.AdicionarParametros("@Usuario", cadastro.Nome_Usuario);
            acessoBDSql.AdicionarParametros("@Sexo", cadastro.Sexo);
            acessoBDSql.AdicionarParametros("@Idade", cadastro.Idade);
            acessoBDSql.AdicionarParametros("@Senha", cadastro.Senha);


            string nome_usuario = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "CadastroExcluir").ToString();
            return nome_usuario;

        }
        catch (Exception ex)
        {

            return ex.Message;
        }
    }
    // ALTERAR cadastro
    public string CadastroAlterar(Cadastro cadastro)
    {
        try
        {
            acessoBDSql.LimparParametros();


            acessoBDSql.AdicionarParametros("@Usuario", cadastro.Nome_Usuario);
            acessoBDSql.AdicionarParametros("@Sexo", cadastro.Sexo);
            acessoBDSql.AdicionarParametros("@Idade", cadastro.Idade);
            acessoBDSql.AdicionarParametros("@Senha", cadastro.Senha);

            string usuario = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "CadastroAlterar").ToString();
            string sexo = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "CadastroAlterar").ToString();
            string idade = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "CadastroAlterar").ToString();
            string senha = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "CadastroAlterar").ToString();

            return usuario;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    // ALTERAR PROGRESSO
    public string ProgressoAlterar(PerfilUsuario progresso)
    {
        try
        {
            acessoBDSql.LimparParametros();

            acessoBDSql.AdicionarParametros("@licao_usuario", progresso.licao_usuario);
            acessoBDSql.AdicionarParametros("@Modulo_usuario", progresso.modulo_usuario);
            acessoBDSql.AdicionarParametros("@progre_usuario", progresso.progresso_usuario);

            string licao_usuario = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "ProgressoAlterar").ToString();
            string modulo_usuario = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "ProgressoAlterar").ToString();
            string progresso_usuario = acessoBDSql.ManipulaDados(System.Data.CommandType.StoredProcedure, "ProgressoAlterar").ToString();

            return progresso_usuario;
        }
        catch (Exception ex)
        {
            return ex.Message;
        }
    }

    //CONSULTAR cadastro Usuario nome

    // chama classe do obj_trans: CADASTRO
    public Cadastro ConsultarCadastroUsuario(string nomeUsuario)
    {
        try
        {
            Cadastro cadastroNomeUsuario = new Cadastro();

            acessoBDSql.LimparParametros();
            acessoBDSql.AdicionarParametros("@Usuario", nomeUsuario);

            DataTable dataTableCadastro = acessoBDSql.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "CadastroConsultarUsuario");

            foreach (DataRow linha in dataTableCadastro.Rows)
            {
                Cadastro cadastroUsuario = new Cadastro();

                cadastroUsuario.Cod_cadastro = Convert.ToInt32(linha["Cod_cadastro"]);
                cadastroUsuario.Nome_Usuario = Convert.ToString(linha["Usuario"]);
                cadastroUsuario.Sexo = Convert.ToString(linha["Sexo"]);
                cadastroUsuario.Idade = Convert.ToString(linha["Idade"]);
                cadastroUsuario.Senha = Convert.ToString(linha["Senha"]);


                // ????????
                cadastroNomeUsuario.Equals(cadastroUsuario);
            }

            return cadastroNomeUsuario;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    // CONSULTA Cadastro COD_CADASTRO
    public Cadastro ConstultarCadastroCod_cadastro(string codCadastro)
    {
        try
        {
            Cadastro cadastroConsultar = new Cadastro();

            acessoBDSql.LimparParametros();
            acessoBDSql.AdicionarParametros("@Cod_cadastro", codCadastro);

            DataTable dataTableCadastro = acessoBDSql.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "CadastroConsultarCod");

            foreach (DataRow linha in dataTableCadastro.Rows)
            {

                Cadastro cadastroCod = new Cadastro();

                cadastroCod.Cod_cadastro = Convert.ToInt32(linha["Cod_cadastro"]);
                cadastroCod.Nome_Usuario = Convert.ToString(linha["Usuario"]);
                cadastroCod.Sexo = Convert.ToString(linha["Sexo"]);
                cadastroCod.Idade = Convert.ToString(linha["Idade"]);
                cadastroCod.Senha = Convert.ToString(linha["Senha"]);

                cadastroConsultar.Equals(cadastroCod); // ?
            }

            return cadastroConsultar;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
    // CONSULTAR Progresso Usuario: PerfilUsuario(CLASSE)
    public PerfilUsuario ConsultarProgressoUsuario(string CodProgresso)
    {
        try
        {
            PerfilUsuario perfilUsuario = new PerfilUsuario();

            acessoBDSql.LimparParametros();
            acessoBDSql.AdicionarParametros("@Cod_progresso", CodProgresso);
            DataTable dataTableProgresso = acessoBDSql.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "ProgressoConsultar");

            foreach (DataRow linha in dataTableProgresso.Rows)
            {

                PerfilUsuario perfilUsuarioConsulta = new PerfilUsuario();

                perfilUsuarioConsulta.Cod_Progresso = Convert.ToInt32(linha["Cod_Progresso"]);
                perfilUsuarioConsulta.cod_teste = Convert.ToInt32(linha["Cod_teste"]);
                perfilUsuarioConsulta.licao_usuario = Convert.ToInt32(linha["Licao_Usuario"]);
                perfilUsuarioConsulta.modulo_usuario = Convert.ToInt32(linha["Modulo_Usuario"]);
                perfilUsuarioConsulta.progresso_usuario = Convert.ToInt32(linha["Progre_usuario"]);

                perfilUsuario.Equals(perfilUsuario);


            }

            return perfilUsuario;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
    // CONSULTAR TESTE
    public PerfilUsuario ConsultarTeste(string teste)
    {
        try
        {
            PerfilUsuario ConsultaTeste = new PerfilUsuario();

            acessoBDSql.LimparParametros();
            acessoBDSql.AdicionarParametros("@Cod_Teste", teste);

            DataTable dataTableTeste = acessoBDSql.ExecutaConsulta(System.Data.CommandType.StoredProcedure, "TesteConsultar");

            foreach (DataRow linha in dataTableTeste.Rows)
            {

                PerfilUsuario testeUsuario = new PerfilUsuario();

                testeUsuario.cod_teste = Convert.ToInt32(linha["Cod_Teste"]);
                testeUsuario.resultado = Convert.ToInt32(linha["Resultado"]);


                ConsultaTeste.Equals(testeUsuario);

            }

            return ConsultaTeste;

        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
}

