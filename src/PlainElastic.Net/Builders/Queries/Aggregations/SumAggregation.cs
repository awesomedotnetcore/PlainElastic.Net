using PlainElastic.Net.Utils;

namespace PlainElastic.Net.Queries
{
    /// <summary>
	/// A single-value metrics aggregation that sums up numeric values that are extracted from the aggregated documents.
	/// These values can be extracted either from specific numeric fields in the documents, or be generated by a provided script.
	/// see http://www.elasticsearch.org/guide/en/elasticsearch/reference/current/search-aggregations-metrics-sum-aggregation.html
    /// </summary>
    public class SumAggregation<T> : ValueAggregationBase<SumAggregation<T>, T>
    {

        protected override string ApplyAggregationBodyJsonTemplate(string body)
        {
            return "'sum': {{ {0} }}".AltQuoteF(body);
        }
        
    }
}