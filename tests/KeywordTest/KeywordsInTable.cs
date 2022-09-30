// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace KeywordTest
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct KeywordsInTable : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_22_9_29(); }
  public static KeywordsInTable GetRootAsKeywordsInTable(ByteBuffer _bb) { return GetRootAsKeywordsInTable(_bb, new KeywordsInTable()); }
  public static KeywordsInTable GetRootAsKeywordsInTable(ByteBuffer _bb, KeywordsInTable obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public KeywordsInTable __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public KeywordTest.ABC Is { get { int o = __p.__offset(4); return o != 0 ? (KeywordTest.ABC)__p.bb.GetInt(o + __p.bb_pos) : KeywordTest.ABC.@void; } }
  public bool MutateIs(KeywordTest.ABC @is) { int o = __p.__offset(4); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, (int)@is); return true; } else { return false; } }
  public KeywordTest.@public Private { get { int o = __p.__offset(6); return o != 0 ? (KeywordTest.@public)__p.bb.GetInt(o + __p.bb_pos) : KeywordTest.@public.NONE; } }
  public bool MutatePrivate(KeywordTest.@public @private) { int o = __p.__offset(6); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, (int)@private); return true; } else { return false; } }
  public int Type { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetInt(o + __p.bb_pos) : (int)0; } }
  public bool MutateType(int type) { int o = __p.__offset(8); if (o != 0) { __p.bb.PutInt(o + __p.bb_pos, type); return true; } else { return false; } }
  public bool Default { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }
  public bool MutateDefault(bool @default) { int o = __p.__offset(10); if (o != 0) { __p.bb.Put(o + __p.bb_pos, (byte)(@default ? 1 : 0)); return true; } else { return false; } }

  public static Offset<KeywordTest.KeywordsInTable> CreateKeywordsInTable(FlatBufferBuilder builder,
      KeywordTest.ABC @is = KeywordTest.ABC.@void,
      KeywordTest.@public @private = KeywordTest.@public.NONE,
      int type = 0,
      bool @default = false) {
    builder.StartTable(4);
    KeywordsInTable.AddType(builder, type);
    KeywordsInTable.AddPrivate(builder, @private);
    KeywordsInTable.AddIs(builder, @is);
    KeywordsInTable.AddDefault(builder, @default);
    return KeywordsInTable.EndKeywordsInTable(builder);
  }

  public static void StartKeywordsInTable(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddIs(FlatBufferBuilder builder, KeywordTest.ABC @is) { builder.AddInt(0, (int)@is, 0); }
  public static void AddPrivate(FlatBufferBuilder builder, KeywordTest.@public @private) { builder.AddInt(1, (int)@private, 0); }
  public static void AddType(FlatBufferBuilder builder, int type) { builder.AddInt(2, type, 0); }
  public static void AddDefault(FlatBufferBuilder builder, bool @default) { builder.AddBool(3, @default, false); }
  public static Offset<KeywordTest.KeywordsInTable> EndKeywordsInTable(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<KeywordTest.KeywordsInTable>(o);
  }
  public KeywordsInTableT UnPack() {
    var _o = new KeywordsInTableT();
    this.UnPackTo(_o);
    return _o;
  }
  public void UnPackTo(KeywordsInTableT _o) {
    _o.Is = this.Is;
    _o.Private = this.Private;
    _o.Type = this.Type;
    _o.Default = this.Default;
  }
  public static Offset<KeywordTest.KeywordsInTable> Pack(FlatBufferBuilder builder, KeywordsInTableT _o) {
    if (_o == null) return default(Offset<KeywordTest.KeywordsInTable>);
    return CreateKeywordsInTable(
      builder,
      _o.Is,
      _o.Private,
      _o.Type,
      _o.Default);
  }
}

public class KeywordsInTableT
{
  [Newtonsoft.Json.JsonProperty("is")]
  public KeywordTest.ABC Is { get; set; }
  [Newtonsoft.Json.JsonProperty("private")]
  public KeywordTest.@public Private { get; set; }
  [Newtonsoft.Json.JsonProperty("type")]
  public int Type { get; set; }
  [Newtonsoft.Json.JsonProperty("default")]
  public bool Default { get; set; }

  public KeywordsInTableT() {
    this.Is = KeywordTest.ABC.@void;
    this.Private = KeywordTest.@public.NONE;
    this.Type = 0;
    this.Default = false;
  }
}


}
