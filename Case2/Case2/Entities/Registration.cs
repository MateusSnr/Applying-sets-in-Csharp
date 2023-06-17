using System;

namespace Case2.Entities
{
    class Registration
    {
        public int RegistrationNumber { get; set; }

        public override int GetHashCode()
        {
            return RegistrationNumber.GetHashCode();
            //O comparador será baseado no hashcode da matrícula
            //Critério de igualdade é a matricula
        }

        public override bool Equals(object obj)//Qnd uma matricula vai ser igual a outro obj ?
        {
            if (!(obj is Registration))//Testa se o obj realmente é do tipo matricula
            {
                return false;//objs não são iguais
            }
            Registration other = obj as Registration;//downcasting
            return RegistrationNumber.Equals(other.RegistrationNumber);//Uma matricula é igual a outra
            //quando o registrationnumber deles forem iguais
        }

        //Uma matrícula repetida, não é adicionada ao conjunto pois o equals e o hashcode são baseados
        //no número de matrícula.
    }
}
