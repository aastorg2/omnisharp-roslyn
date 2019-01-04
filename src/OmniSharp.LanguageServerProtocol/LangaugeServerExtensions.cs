using System.Collections.Generic;
using OmniSharp.Extensions.JsonRpc;
using OmniSharp.Extensions.LanguageServer.Server;

namespace OmniSharp.LanguageServerProtocol
{
    public static class LangaugeServerExtensions
    {
        public static ILanguageServer AddHandlers(this ILanguageServer langaugeServer, IEnumerable<IJsonRpcHandler> handlers)
        {
            foreach (var handler in handlers)
                langaugeServer.AddHandlers(handler);
            return langaugeServer;
        }
    }
}
