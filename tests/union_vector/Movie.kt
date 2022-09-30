// automatically generated by the FlatBuffers compiler, do not modify

import java.nio.*
import kotlin.math.sign
import com.google.flatbuffers.*

@Suppress("unused")
class Movie : Table() {

    fun __init(_i: Int, _bb: ByteBuffer)  {
        __reset(_i, _bb)
    }
    fun __assign(_i: Int, _bb: ByteBuffer) : Movie {
        __init(_i, _bb)
        return this
    }
    val mainCharacterType : UByte
        get() {
            val o = __offset(4)
            return if(o != 0) bb.get(o + bb_pos).toUByte() else 0u
        }
    fun mutateMainCharacterType(mainCharacterType: UByte) : Boolean {
        val o = __offset(4)
        return if (o != 0) {
            bb.put(o + bb_pos, mainCharacterType.toByte())
            true
        } else {
            false
        }
    }
    fun mainCharacter(obj: Table) : Table? {
        val o = __offset(6); return if (o != 0) __union(obj, o + bb_pos) else null
    }
    fun charactersType(j: Int) : UByte {
        val o = __offset(8)
        return if (o != 0) {
            bb.get(__vector(o) + j * 1).toUByte()
        } else {
            0u
        }
    }
    val charactersTypeLength : Int
        get() {
            val o = __offset(8); return if (o != 0) __vector_len(o) else 0
        }
    val charactersTypeAsByteBuffer : ByteBuffer get() = __vector_as_bytebuffer(8, 1)
    fun charactersTypeInByteBuffer(_bb: ByteBuffer) : ByteBuffer = __vector_in_bytebuffer(_bb, 8, 1)
    fun mutateCharactersType(j: Int, charactersType: UByte) : Boolean {
        val o = __offset(8)
        return if (o != 0) {
            bb.put(__vector(o) + j * 1, charactersType.toByte())
            true
        } else {
            false
        }
    }
    fun characters(obj: Table, j: Int) : Table? {
        val o = __offset(10)
        return if (o != 0) {
            __union(obj, __vector(o) + j * 4)
        } else {
            null
        }
    }
    val charactersLength : Int
        get() {
            val o = __offset(10); return if (o != 0) __vector_len(o) else 0
        }
    companion object {
        fun validateVersion() = Constants.FLATBUFFERS_22_9_29()
        fun getRootAsMovie(_bb: ByteBuffer): Movie = getRootAsMovie(_bb, Movie())
        fun getRootAsMovie(_bb: ByteBuffer, obj: Movie): Movie {
            _bb.order(ByteOrder.LITTLE_ENDIAN)
            return (obj.__assign(_bb.getInt(_bb.position()) + _bb.position(), _bb))
        }
        fun MovieBufferHasIdentifier(_bb: ByteBuffer) : Boolean = __has_identifier(_bb, "MOVI")
        fun createMovie(builder: FlatBufferBuilder, mainCharacterType: UByte, mainCharacterOffset: Int, charactersTypeOffset: Int, charactersOffset: Int) : Int {
            builder.startTable(4)
            addCharacters(builder, charactersOffset)
            addCharactersType(builder, charactersTypeOffset)
            addMainCharacter(builder, mainCharacterOffset)
            addMainCharacterType(builder, mainCharacterType)
            return endMovie(builder)
        }
        fun startMovie(builder: FlatBufferBuilder) = builder.startTable(4)
        fun addMainCharacterType(builder: FlatBufferBuilder, mainCharacterType: UByte) = builder.addByte(0, mainCharacterType.toByte(), 0)
        fun addMainCharacter(builder: FlatBufferBuilder, mainCharacter: Int) = builder.addOffset(1, mainCharacter, 0)
        fun addCharactersType(builder: FlatBufferBuilder, charactersType: Int) = builder.addOffset(2, charactersType, 0)
        fun createCharactersTypeVector(builder: FlatBufferBuilder, data: UByteArray) : Int {
            builder.startVector(1, data.size, 1)
            for (i in data.size - 1 downTo 0) {
                builder.addByte(data[i].toByte())
            }
            return builder.endVector()
        }
        fun startCharactersTypeVector(builder: FlatBufferBuilder, numElems: Int) = builder.startVector(1, numElems, 1)
        fun addCharacters(builder: FlatBufferBuilder, characters: Int) = builder.addOffset(3, characters, 0)
        fun createCharactersVector(builder: FlatBufferBuilder, data: IntArray) : Int {
            builder.startVector(4, data.size, 4)
            for (i in data.size - 1 downTo 0) {
                builder.addOffset(data[i])
            }
            return builder.endVector()
        }
        fun startCharactersVector(builder: FlatBufferBuilder, numElems: Int) = builder.startVector(4, numElems, 4)
        fun endMovie(builder: FlatBufferBuilder) : Int {
            val o = builder.endTable()
            return o
        }
        fun finishMovieBuffer(builder: FlatBufferBuilder, offset: Int) = builder.finish(offset, "MOVI")
        fun finishSizePrefixedMovieBuffer(builder: FlatBufferBuilder, offset: Int) = builder.finishSizePrefixed(offset, "MOVI")
    }
}
