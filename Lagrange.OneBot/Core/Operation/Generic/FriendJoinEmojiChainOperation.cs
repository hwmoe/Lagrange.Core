using System.Text.Json;
using System.Text.Json.Nodes;
using Lagrange.Core;
using Lagrange.Core.Message;
using Lagrange.Core.Common.Interface.Api;
using Lagrange.OneBot.Core.Entity.Action;
using Lagrange.OneBot.Core.Operation.Converters;
using Lagrange.OneBot.Database;


namespace Lagrange.OneBot.Core.Operation.Generic;


[Operation(".join_friend_emoji_chain")]
public class FriendJoinEmojiChainOperation() : IOperation
{
    public async Task<OneBotResult> HandleOperation(BotContext context, JsonNode? payload)
    {
        if (payload.Deserialize<OneBotPrivateJoinEmojiChain>(SerializerOptions.DefaultOptions) is { } data)
        {
            //var message = (MessageChain)database.GetCollection<MessageRecord>().FindById(data.MessageId);
            //bool res = await context.FriendJoinEmojiChain(data.UserId, data.EmojiId, message.Sequence);
            //return new OneBotResult(null, res ? 0 : -1, res ? "ok" : "failed");
            return new OneBotResult(null, 0, "ok");
        }
        throw new Exception();
    }
}
