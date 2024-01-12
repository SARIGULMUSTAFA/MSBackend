using System;
using System.Collections.Generic;
using System.Text;

namespace MsBackend.Core.Utilities.Result
{
    //Temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
