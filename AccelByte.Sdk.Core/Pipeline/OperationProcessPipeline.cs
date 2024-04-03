// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Threading.Tasks;

namespace AccelByte.Sdk.Core.Pipeline
{
    public class OperationProcessPipeline : IOperationProcessPipeline
    {
        private IOperationProcess? First { get; set; } = null;

        private IOperationProcess? Last { get; set; } = null;

        public void AppendToChain(IOperationProcess handler)
        {
            if (First == null)
            {
                First = handler;
                Last = handler;
            }
            else if (Last == null)
            {
                IOperationProcess temp = First;
                while (temp.Next != null)
                    temp = temp.Next;
                Last = temp;

                Last.Next = handler;
                Last = handler;
            }
            else
            {
                Last.Next = handler;
                Last = handler;
            }
        }

        public void PrependToChain(IOperationProcess handler)
        {
            if (First == null)
            {
                First = handler;
                Last = handler;
            }
            else
            {
                handler.Next = First;
                First = handler;
            }
        }

        public IOperation RunProcessPipeline(IOperation op, IAccelByteSdk sdk)
        {
            if (First == null)
                throw new Exception("No operation process handler in chain.");

            IOperationProcess handler = First;
            IOperation resultOp = handler.Handle(op, sdk);
            while (handler.Next != null)
            {
                handler = handler.Next;
                resultOp = handler.Handle(resultOp, sdk);
            }

            return resultOp;
        }

        public async Task<IOperation> RunProcessPipelineAsync(IOperation op, IAccelByteSdk sdk)
        {
            if (First == null)
                throw new Exception("No operation process handler in chain.");

            IOperationProcess handler = First;

            IOperation resultOp;
            if (handler is IOperationProcessAsync)
                resultOp = await ((IOperationProcessAsync)handler).HandleAsync(op, sdk);
            else
                resultOp = handler.Handle(op, sdk);

            while (handler.Next != null)
            {
                handler = handler.Next;

                if (handler is IOperationProcessAsync)
                    resultOp = await ((IOperationProcessAsync)handler).HandleAsync(resultOp, sdk);
                else
                    resultOp = handler.Handle(resultOp, sdk);
            }

            return resultOp;
        }
    }
}