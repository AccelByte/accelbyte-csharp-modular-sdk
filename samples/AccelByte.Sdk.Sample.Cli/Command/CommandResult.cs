using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Sample.Cli.Command
{
    public class CommandResult
    {
        public bool IsSuccess { get; set; } = false;

        public string Result { get; set; } = "";

        public static CommandResult Success(string result)
        {
            return new CommandResult()
            {
                IsSuccess = true,
                Result = result
            };
        }

        public static CommandResult Fail(string errorCode, string errorMessage)
        {
            return new CommandResult()
            {
                IsSuccess = false,
                Result = $"Failed. Code: {errorCode}. {errorMessage}"
            };
        }
    }
}
