using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSServerless2
{
    public class UserFunction
    {
        private static List<string> items = new List<string>();

        public APIGatewayProxyResponse CreateUser(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Parse the request body and create a new item
            string newItem = request.Body;
            items.Add(newItem);

            return new APIGatewayProxyResponse
            {
                StatusCode = 201,
                Body = "Item created successfully"
            };
        }

        public APIGatewayProxyResponse ReadAllUsers(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Return all items
            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body ="User List function"
            };
        }

    }
}
