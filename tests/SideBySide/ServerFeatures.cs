using System;

namespace SideBySide
{
	[Flags]
	public enum ServerFeatures
	{
		None = 0,
		Json = 1,
		StoredProcedures = 2,
		Sha256Password = 4,
		OpenSsl = 8,
		LargePackets = 16,
		CachingSha2Password = 32,
		SessionTrack = 64,
		Timeout = 128,
		ErrorCodes = 256,
		KnownCertificateAuthority = 512,
	}
}
