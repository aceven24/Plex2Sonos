using ProtoBuf;
using System;

namespace Plex2Sonos.Plex
{
    [ProtoContract]
    [ProtoInclude(20, typeof(MusicSection))]
    [ProtoInclude(30, typeof(Artist))]
    [ProtoInclude(40, typeof(Album))]
    [ProtoInclude(50, typeof(Track))]
    public class MediaContainer
    {
        [ProtoMember(1)]
        public string Key { get; set; }
        [ProtoMember(2)]
        public string Name { get; set; }
        [ProtoMember(3)]
        public string SortName { get; set; }
        [ProtoMember(4)]
        public string Summary { get; set; }
        [ProtoMember(5)]
        public int RatingsKey { get; set; }
        [ProtoMember(6)]
        public string ThumbLocation { get; set; }
        [ProtoMember(7)]
        public string Art { get; set; }
        [ProtoMember(8, AsReference = true)]
        public MediaContainer Parent { get; set; }
        [ProtoMember(9)]
        public DateTime LastUpdated { get; set; }
        [ProtoMember(10)]
        public DateTime? LastProcessed { get; set; }
        [ProtoMember(11)]
        public int Index { get; set; }

        public MediaContainer()
        {

        }

        public MediaContainer(MediaContainer parentContainer)
        {
            this.Parent = parentContainer;
        }

        protected virtual void PopulateMediaContainerProperties(dynamic dynMediaContainer)
        {

        }
        protected void PopulateBaseMediaContainerProperties(dynamic dynMediaContainer)
        {
            this.Name = dynMediaContainer.title;
            this.Summary = dynMediaContainer.summary;
            this.RatingsKey = (int)dynMediaContainer.ratingKey;

            var lastUpdated = AttemptDynamicPropertyExtract<long?>(() => { return dynMediaContainer.updatedAt; }, () => { return null; });
            if (lastUpdated != null)
            {
                this.LastUpdated = DateTimeOffset.FromUnixTimeSeconds(lastUpdated.Value).DateTime;
            }
            else
            {
                this.LastUpdated = DateTimeOffset.FromUnixTimeSeconds(dynMediaContainer.addedAt).DateTime;
            }
            this.Index = (int)dynMediaContainer.index;
            this.Key = ((string)dynMediaContainer.key).Substring(1);
            this.ThumbLocation = AttemptDynamicPropertyExtract<string>(() => { return dynMediaContainer.thumb; }, () => { return string.Empty; });
            this.Art = AttemptDynamicPropertyExtract<string>(() => { return dynMediaContainer.art; }, () => { return string.Empty; });
            this.LastProcessed = DateTime.Now;
        }

        protected static T AttemptDynamicPropertyExtract<T>(Func<T> property, Func<T> empty)
        {
            try
            {
                return property();
            }
            catch (Exception)
            {
                return empty();
            }
        }
    }
}
