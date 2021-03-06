﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DahuaSharp.Packets
{
    internal class CaptureRequest : BinaryPacket
    {
        [Field(0)]
        private static readonly byte[] HeaderData = {
                                0x00, 0x00, 0x00, 0x28, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x0a, 0x00, 0x00, 0x00 };

        [Field(1)]
        public byte Channel { get; private set; }

        [Field(2)]
        private static readonly byte[] Footer = {
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00,
                                0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };


        public CaptureRequest() : base(0x11) { }

        public CaptureRequest(byte channel) : base(0x11)
        {
            Channel = channel;
        }
    }
}
