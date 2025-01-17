using System.Text.Json;
using System.Text.Json.Nodes;
using Lagrange.Core;
using Lagrange.Core.Common.Interface.Api;
using Lagrange.Core.Message;
using Lagrange.OneBot.Core.Entity.Action;
using Lagrange.OneBot.Core.Operation.Converters;
using Lagrange.OneBot.Database;


namespace Lagrange.OneBot.Core.Operation.Message;

[Operation("set_essence_msg")]
public class SetEssenceMessageOperation() : IOperation
{
    public async Task<OneBotResult> HandleOperation(BotContext context, JsonNode? payload)
    {
        if (payload.Deserialize<OneBotGetMessage>(SerializerOptions.DefaultOptions) is { } getMsg)
        {
            //var record = database.GetCollection<MessageRecord>().FindById(getMsg.MessageId);
            //var chain = (MessageChain)record;
            //bool result = await context.SetEssenceMessage(chain);
            //return new OneBotResult(null, result ? 0 : 1, result ? "ok" : "failed");
            return new OneBotResult(null, 0, "ok");
        }

        throw new Exception();
    }
}