﻿// Copyright (c) 2022-2023 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System;
using System.Collections.Generic;
using System.Reflection;

using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Awesome;
using AccelByte.Sdk.Sample.Cli.Command;

namespace AccelByte.Sdk.Sample.Cli
{
    internal class Program
    {
        static int Main(string[] args)
        {
            try
            {
                CommandArguments cArgs = new CommandArguments(args);
                CommandFactory cFactory = new CommandFactory(
                    "AccelByte.Sdk.Sample.Cli.ApiCommand",
                    Assembly.GetExecutingAssembly());

                if (cArgs.IsWebSocket)
                {
                    if (cArgs.ServiceName == String.Empty)
                        throw new Exception("Unspecified service name for websocket service.");

                    using IAccelByteSdk sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    WebSocketCommand wsCmd = new WebSocketCommand(sdk.Configuration, cArgs.IsRetryOnWSMessageError);
                    if (cArgs.IsWebSocketListenMode)
                        wsCmd.Listen(cArgs.ServiceName);
                    else
                    {
                        if (cArgs.IsInteractive)
                        {
                            CommandMenu iMenu = new CommandMenu()
                            {
                                MainMenu = "WebSocket Message",
                                MenuQuestion = "Select message type to send"
                            };

                            List<Type> wsqTypes = wsCmd.GetModelTypes(cArgs.ServiceName, true);

                            int counter = 1;
                            foreach (Type t in wsqTypes)
                            {
                                iMenu.Add(counter.ToString(), t.Name, () =>
                                {
                                    object wsModelObj = SdkHelper.CreateWSModelObject(t, (fName, pi, wsObj) =>
                                    {
                                        Console.Write("\t{0} ? ", fName);
                                        string value = Console.ReadLine()!.Trim();
                                        Console.WriteLine();
                                        return value;
                                    });

                                    string response = wsCmd.Execute(cArgs.ServiceName, wsModelObj);
                                    if (response == String.Empty)
                                        Console.WriteLine("EMPTY RESPONSE!");
                                    else
                                        Console.WriteLine("Response:\n{0}", response);

                                    Console.Write("<ENTER> to continue");
                                    Console.ReadLine();
                                    Console.WriteLine();
                                });
                                counter++;
                            }
                            iMenu.AddExitItem("x", "Exit", true);
                            iMenu.Run();
                            return 0;
                        }
                        else
                        {
                            string response = wsCmd.Execute(cArgs.ServiceName, cArgs.WebSocketPayload);
                            if (response == String.Empty)
                                return 2;

                            Console.Write("Response:\n{0}", response);
                        }
                    }
                }
                else if (cArgs.OperationName == "")
                {
                    if (cArgs.IsListAllAsked)
                    {
                        IAccelByteSdk sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllOperations(sdk);
                    }
                    else if (cArgs.IsListAsked && (cArgs.ServiceName == String.Empty))
                    {
                        IAccelByteSdk sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllServiceNames(sdk);
                    }
                    else if (cArgs.IsListAsked && (cArgs.ServiceName != String.Empty))
                    {
                        IAccelByteSdk sdk = SdkHelper.CreatyEmptySdk();
                        cFactory.EchoAllOperationInService(sdk, cArgs.ServiceName);
                    }
                    else
                        cArgs.EchoUsage();
                }
                else if (cArgs.OperationName == "login")
                {
                    IAccelByteSdk sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                }
                else
                {
                    IAccelByteSdk sdk = SdkHelper.CreateSdkAndLogin(cArgs);
                    ISdkConsoleCommand cmd = cFactory.CreateCommandObject(cArgs, sdk);
                    if (cArgs.IsHelpAsked)
                    {
                        cArgs.EchoUsage();
                        cFactory.EchoCommandParams(cmd);
                    }
                    else
                    {
                        CommandResult result = cmd.Run();
                        if (result.IsSuccess)
                            Console.WriteLine("Response:\n{0}", result.Result);
                        else
                        {
                            Console.WriteLine("Error: \n{0}", result.Result);
                            return 2;
                        }
                    }
                }

                return 0;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Exception: {0}", ex.Message);
                return 2;
            }
        }
    }
}