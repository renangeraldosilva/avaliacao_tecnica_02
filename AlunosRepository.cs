using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Avaliacao2
{
    public static class AlunosRepository
    {
        static List<Aluno> alunos = new List<Aluno>()
        {
           new Aluno("Maria José Santos", "069.658.069-15", 15, "(16) 9 9985-9999", "1° A", "R. Avanhandava, 16598 - Bela Vista"),
           new Aluno("Joene Kennedy", "569.958.069-18" , 16, "(19) 9 2185-9798", "2º C", "R. Frei Caneca, 4912 - Consolação" ),
           new Aluno("João Marcos", "159.658.123-13", 15, "(16) 9 8888-7777", "1º B", "R. Maj. Sertório, 25428 - República"),
           new Aluno("Carlos André", "061.658.097-10", 15, "(15) 9 1111-2524", "1º A", "R. Gen. Jardim, 54749 - Vila Buarque"),
           new Aluno("Ane Maria","098.644.009-01", 17, "(18) 9 2222-4587", "3° A","R. Aurora, 97845 - Centro Histórico de São Paulo"),
           new Aluno("Marcos Silva","222.655.129-18", 16, "(15) 9 9999-8758", "2° A", "R. Antônio Pais, 6598 - Centro Histórico de São Paulo"),
           new Aluno("Rafael Freire","169.555.502-16", 17, "(19) 9 2589-5215", "3° C", "R. Três Rios, 3069 - Bom Retiro"),
        };

        public static void Cadastrar(Aluno aluno)
        {
           alunos.Add(aluno);
        }

        public static List<Aluno> Listar()
        {
            return alunos;
        }

    }
}
