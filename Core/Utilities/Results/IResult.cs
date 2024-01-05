using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    //İşlem sonucu ve kullancııyı bilgilendirme mesajı 
    public interface IResult
    {
        bool Success { get; } //Başarılı mı başarısız mı

        string Message { get; }
    } 
}
