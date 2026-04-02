namespace QBCH_api.Configuration;

public class ApiV3ContractOptions
{
    public const string SectionName = "ApiV3Contract";

    public int MaxDlRequestBatchSize { get; init; } = 10;
    public int MaxDlPutEntities { get; init; } = 1000;
    public int MinAnswerPollingIntervalSeconds { get; init; } = 1;
    public int ResponseRetentionHours { get; init; } = 8;
    public int HttpClientTimeoutSeconds { get; init; } = 4;
}
