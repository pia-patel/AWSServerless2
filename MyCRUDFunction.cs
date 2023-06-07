using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSServerless2
{
    public class MyCRUDFunction
    {
        public MyCRUDFunction()
        {

        }
        private static List<string> items = new List<string>();

        public APIGatewayProxyResponse Create(APIGatewayProxyRequest request, ILambdaContext context)
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

        public APIGatewayProxyResponse ReadAll(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Return all items
            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = "Items List function"
            };
        }

        public APIGatewayProxyResponse Update(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Parse the request body and update an item
            string updatedItem = request.Body;
            int index = int.Parse(request.PathParameters["id"]);
            items[index] = updatedItem;

            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = "Item updated successfully"
            };
        }

        public APIGatewayProxyResponse Delete(APIGatewayProxyRequest request, ILambdaContext context)
        {
            // Delete an item
            int index = int.Parse(request.PathParameters["id"]);
            items.RemoveAt(index);

            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = "Item deleted successfully"
            };
        }
    }
}
