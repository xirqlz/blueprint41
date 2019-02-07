﻿using Blueprint41.Response;
using Gremlin.Net.Driver;
using Gremlin.Net.Driver.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Blueprint41.Gremlin
{
    public static class GremlinClientExtension
    {
        public static async Task<GraphResponse> QueryAsync(this GremlinClient client, string query)
        {
            try
            {
                ResultSet<JToken> result = await client.SubmitAsync<JToken>(query);
                return GraphResponse.GetGraphResponse<GremlinResult>(result);
            }

            catch (ResponseException ex)
            {
                return GraphResponse.GetGraphResponse<GremlinResult>(ex);
            }
        }
    }
}