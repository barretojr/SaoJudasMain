using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJmain.Classes
{
    public class Livros
    {
        Conexao conec = new Conexao();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;        
        
        public int Id { get; set; }
        public string Titulo { get; set; }
        public byte[] Pdf { get; set; }

        public void Get(int id, Livros livro)
        {
            var sql = "SELECT titulo, pdf FROM Livros WHERE Id=" + id;
            cmd.Connection = conec.Conectar();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    livro.Id = id;
                    livro.Titulo = dr["titulo"].ToString();
                    livro.Pdf = (byte[])dr["pdf"];
                }
            }
        }
        public void Salvar(Livros livro, string caminhopdf)
        {
            byte[] pdf = GetPdf(caminhopdf);
            var sql = "INSERT INTO Livros (titulo, pdf) VALUES ('@titulo', @pdf)";
            cmd.Connection = conec.Conectar();
            cmd.Parameters.AddWithValue("@titulo", livro.Titulo);
            cmd.Parameters.AddWithValue("@pdf",pdf.Length).Value = pdf;
            cmd.ExecuteNonQuery();
        }
        private byte[] GetPdf(string caminhopdf)
        {
            byte[] pdf;
            using (var stream = new FileStream(caminhopdf, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    pdf = reader.ReadBytes((int)stream.Length);
                }
            }
            return pdf;

        }
    }
}
