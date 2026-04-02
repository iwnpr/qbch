namespace QBCH_api.Configuration;

public class ApiV3ContractRules(ApiV3ContractOptions options)
{
    public bool IsDlRequestBatchSizeValid(int count) => count <= options.MaxDlRequestBatchSize;

    public bool IsDlPutEntitiesCountValid(int count) => count <= options.MaxDlPutEntities;

    public bool IsAnswerRetryAllowed(DateTimeOffset previousRequestUtc, DateTimeOffset currentRequestUtc) =>
        currentRequestUtc - previousRequestUtc >= TimeSpan.FromSeconds(options.MinAnswerPollingIntervalSeconds);
}