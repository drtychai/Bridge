namespace System.Diagnostics
{
    [Bridge.External]
    public class Stopwatch
    {
        public static readonly long Frequency = 0;
        public static readonly bool IsHighResolution = false;

        public static extern Stopwatch StartNew();

        public extern TimeSpan Elapsed
        {
            [Bridge.Template("timeSpan()")]
            get;
        }

        public extern long ElapsedMilliseconds
        {
            [Bridge.Template("milliseconds()")]
            get;
        }

        public extern long ElapsedTicks
        {
            [Bridge.Template("ticks()")]
            get;
        }

        [Bridge.Convention(Bridge.Notation.LowerCamelCase)] //[Field]
        public extern bool IsRunning
        {
            get;
        }

        public extern void Reset();

        public extern void Start();

        public extern void Stop();

        public extern void Restart();

        public extern static long GetTimestamp();
    }
}