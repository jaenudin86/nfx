﻿using NUnit.Framework;

namespace NFX.NUnit.Integration.AppModel.Pile
{
  public class PileFragmentationTest64Gb : HighMemoryLoadTest64RAM
  {
    [TestCase(100000, 30, true,  1000, 16000, 3, true)]
    [TestCase(100000, 30, false, 1000, 16000,  10, true)]
    public void Put_RandomDelete_ByteArray(int cnt, int durationSec, bool speed, int payloadSizeMin, int payloadSizeMax, int deleteFreq, bool isParallel)
    {
      PileFragmentationTest.Put_RandomDelete_ByteArray(cnt, durationSec, speed, payloadSizeMin, payloadSizeMax, deleteFreq, isParallel);
    }

    [TestCase(true,  30, 1000, 16000, 3, true)]
    [TestCase(false, 30, 1000, 16000, 3, true)]
    public void DeleteOne_ByteArray(bool speed, int durationSec, int payloadSizeMin, int payloadSizeMax, int deleteFreq, bool isParallel)
    {
      PileFragmentationTest.DeleteOne_ByteArray(speed, durationSec, payloadSizeMin, payloadSizeMax, deleteFreq, isParallel);
    }

    [TestCase(true,  30, 1000, 16000, true)]
    [TestCase(false, 30, 1000, 16000, true)]
    public void Chessboard_ByteArray(bool speed, int durationSec, int payloadSizeMin, int payloadSizeMax, bool isParallel)
    {
      PileFragmentationTest.Chessboard_ByteArray(speed, durationSec, payloadSizeMin, payloadSizeMax, isParallel);
    }

    [TestCase(true,  30, 100, 200, 4, 1000, 16000, true)]
    [TestCase(false, 30, 100, 200, 4, 1000, 16000, true)]
    public void DeleteSeveral_ByteArray(bool speed, int durationSec, int putMin, int putMax, int delFactor, int payloadSizeMin, int payloadSizeMax, bool isParallel)
    {
      PileFragmentationTest.DeleteSeveral_ByteArray(speed, durationSec, putMin, putMax, delFactor, payloadSizeMin, payloadSizeMax, isParallel);
    }

    [TestCase(true,  30, 2, 16000, 100,  2000)]
    [TestCase(false, 30, 2, 16000, 100,  2000)]
    [TestCase(true,  30, 2, 16000, 1000, 2000)]
    [TestCase(false, 30, 2, 16000, 1000, 2000)]

    [TestCase(true,  30, 90333, 160333, 100,  2000)]
    [TestCase(false, 30, 90333, 160333, 100,  2000)]
    [TestCase(true,  30, 90333, 160333, 1000, 2000)]
    [TestCase(false, 30, 90333, 160333, 1000, 2000)]
    public void NoGrowth_ByteArray(bool speed, int durationSec, int payloadSizeMin, int payloadSizeMax, int countMin, int countMax)
    {
      PileFragmentationTest.NoGrowth_ByteArray(speed, durationSec, payloadSizeMin, payloadSizeMax, countMin, countMax);
    }
  }
}
