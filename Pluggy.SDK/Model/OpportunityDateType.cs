using Newtonsoft.Json;
using Pluggy.SDK.Utils;

namespace Pluggy.SDK.Model
{
    [JsonConverter(typeof(TolerantEnumConverter))]
    public enum OpportunityDateType
    {
        YEARLY,
        MONTHLY,
    }
}
