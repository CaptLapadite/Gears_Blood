#if (UNITY_STANDALONE_WIN && !UNITY_EDITOR) || UNITY_EDITOR_WIN
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public enum AkMemPoolAttributes {
  AkNoAlloc = 0,
  AkMalloc = 1 << 0,
  AkVirtualAlloc = 1 << 1,
  AkAllocMask = AkNoAlloc|AkMalloc|AkVirtualAlloc,
  AkFixedSizeBlocksMode = 1 << 3,
  AkBlockMgmtMask = AkFixedSizeBlocksMode
}
#endif // #if (UNITY_STANDALONE_WIN && !UNITY_EDITOR) || UNITY_EDITOR_WIN