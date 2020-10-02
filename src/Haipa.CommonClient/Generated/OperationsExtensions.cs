// <auto-generated>
// MIT
// </auto-generated>

namespace Haipa.CommonClient
{
    using Haipa.ClientRuntime;
    using Haipa.ClientRuntime.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Operations.
    /// </summary>
    public static partial class OperationsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static OperationList List(this IOperations operations, Haipa.ClientRuntime.OData.ODataQuery<Operation> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<Operation>), string select = default(string), bool? count = false)
            {
                return operations.ListAsync(odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationList> ListAsync(this IOperations operations, Haipa.ClientRuntime.OData.ODataQuery<Operation> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<Operation>), string select = default(string), bool? count = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            public static Operation Get(this IOperations operations, System.Guid key, string select = default(string), string expand = default(string))
            {
                return operations.GetAsync(key, select, expand).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='expand'>
            /// Indicates the related entities to be represented inline. The maximum depth
            /// is 2.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Operation> GetAsync(this IOperations operations, System.Guid key, string select = default(string), string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(key, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            public static OperationLogEntryList GetLogEntries(this IOperations operations, System.Guid key, Haipa.ClientRuntime.OData.ODataQuery<OperationLogEntry> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<OperationLogEntry>), string select = default(string), bool? count = false)
            {
                return operations.GetLogEntriesAsync(key, odataQuery, select, count).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='key'>
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='select'>
            /// Limits the properties returned in the result.
            /// </param>
            /// <param name='count'>
            /// Indicates whether the total count of items within a collection are returned
            /// in the result.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<OperationLogEntryList> GetLogEntriesAsync(this IOperations operations, System.Guid key, Haipa.ClientRuntime.OData.ODataQuery<OperationLogEntry> odataQuery = default(Haipa.ClientRuntime.OData.ODataQuery<OperationLogEntry>), string select = default(string), bool? count = false, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetLogEntriesWithHttpMessagesAsync(key, odataQuery, select, count, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}