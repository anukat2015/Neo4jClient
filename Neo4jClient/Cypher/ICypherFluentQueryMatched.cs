namespace Neo4jClient.Cypher
{
    public interface ICypherFluentQueryMatched :  ICypherFluentQueryWhere
    {
        ICypherFluentQueryMatched Relate(string relateText);
        ICypherFluentQueryMatched Create(string createText);
        ICypherFluentQueryMatched Delete(string identities);
        void ExecuteWithoutResults();
    }
}
