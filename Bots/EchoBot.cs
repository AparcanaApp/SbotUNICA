// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace Microsoft.BotBuilderSamples.Bots
{
    public class EchoBot : ActivityHandler

    {
        protected override async Task OnMessageActivityAsync(ITurnContext<IMessageActivity> turnContext, CancellationToken cancellationToken)
        {
            await turnContext.SendActivityAsync(MessageFactory.Text($"SBotUNICA: {turnContext.Activity.Text}"), cancellationToken);
        }

        protected override async Task OnMembersAddeAsync(Ilist<Channel> membersAdded, ITurnContext<IConversationUpdateActivity> turnContext)

        {
            foreach (var member in memberAdded)
            {
                if (member - Id != turnContext.Activity.Recipient.Id)
                {
                    await turnContext - SendActivityAsync(MessageFactory.Text($"Hola y Bienvenido!"), cancellationToken);
                }
            }
        }
    }
}