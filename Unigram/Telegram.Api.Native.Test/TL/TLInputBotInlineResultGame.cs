// <auto-generated/>
using System;
using Telegram.Api.Native.TL;

namespace Telegram.Api.TL
{
	public partial class TLInputBotInlineResultGame : TLInputBotInlineResultBase 
	{
		public String ShortName { get; set; }

		public TLInputBotInlineResultGame() { }
		public TLInputBotInlineResultGame(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.InputBotInlineResultGame; } }

		public override void Read(TLBinaryReader from)
		{
			Id = from.ReadString();
			ShortName = from.ReadString();
			SendMessage = TLFactory.Read<TLInputBotInlineMessageBase>(from);
		}

		public override void Write(TLBinaryWriter to)
		{
			to.WriteString(Id ?? string.Empty);
			to.WriteString(ShortName ?? string.Empty);
			to.WriteObject(SendMessage);
		}
	}
}