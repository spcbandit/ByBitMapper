using JetBrains.Annotations;

using System.Collections.Generic;
using System.ComponentModel;

namespace BybitMapper.Requests
{
    [Browsable(false)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public abstract class UsdcKeyedRequestPayload : RequestPayload
    {

        public int? ActualityWindow { get; set; }

        public long Timestamp { get; set; }

        [NotNull]
        internal override IDictionary<string, string> Properties
        {
            get
            {
                var result = new Dictionary<string, string>();

                return result;
            }
        }

        [NotNull]
        internal override object Body
        {
            get
            {
                var result = new Dictionary<string, string>();

                return result;
            }
        }
    }
}
