using Amazon.DynamoDBv2.DataModel;

namespace CrudDynamoDB.Models
{
    [DynamoDBTable("e-commerce-table")]
    public class Usuario
    {
        [DynamoDBHashKey("pk")]
        public string Site { get; set; }

        [DynamoDBRangeKey("sk")]
        public string Email { get; set; }

        [DynamoDBProperty]
        public string Cidade { get; set; }
        
        [DynamoDBProperty]
        public string Nome { get; set; }
        
        [DynamoDBProperty]
        public string Senha { get; set; }
    }
}
