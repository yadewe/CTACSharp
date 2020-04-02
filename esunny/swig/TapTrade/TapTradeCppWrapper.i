%module TapTradeCppWrapper
%{
#include "iTapAPICommDef.h"
#include "iTapAPIError.h"
#include "iTapTradeAPIDataType.h"
#include "iTapTradeAPI.h"
%}

%typemap(imtype) TAPIUINT32 * "ref uint"
%typemap(cstype) TAPIUINT32 * "ref uint"
%typemap(csout) TAPIUINT32 * "out uint"
%typemap(imtype) TAPIUINT32 & "ref uint"
%typemap(cstype) TAPIUINT32 & "ref uint"

%typemap(imtype) TAPIINT32 * "ref int"
%typemap(cstype) TAPIINT32 * "ref int"
%typemap(csout) TAPIINT32 * "out int"
%typemap(imtype) TAPIINT32 & "ref int"
%typemap(cstype) TAPIINT32 & "ref int"


%typemap(imtype) TAPIINT64 * "ref long"
%typemap(cstype) TAPIINT64 * "ref long"
%typemap(csout) TAPIINT64 * "out long"
%typemap(imtype) TAPIINT64 & "ref long"
%typemap(cstype) TAPIINT64 & "ref long"

%typemap(imtype) TAPIUINT64 * "ref ulong"
%typemap(cstype) TAPIUINT64 * "ref ulong"
%typemap(csout) TAPIUINT64 * "out ulong"
%typemap(imtype) TAPIUINT64 & "ref ulong"
%typemap(cstype) TAPIUINT64 & "ref ulong"

%typemap(imtype) TAPIUINT16 * "ref ushort"
%typemap(cstype) TAPIUINT16 * "ref ushort"
%typemap(csout) TAPIUINT16 * "out ushort"
%typemap(imtype) TAPIUINT16 & "ref ushort"
%typemap(cstype) TAPIUINT16 & "ref ushort"

%typemap(imtype) TAPIUINT8 * "ref char"
%typemap(cstype) TAPIUINT8 * "ref char"
%typemap(csout) TAPIUINT8 * "out char"
%typemap(imtype) TAPIUINT8 & "ref char"
%typemap(cstype) TAPIUINT8 & "ref char"

%typemap(imtype) TAPIREAL64 * "ref double"
%typemap(cstype) TAPIREAL64 * "ref double"
%typemap(csout) TAPIREAL64 * "out double"
%typemap(imtype) TAPIREAL64 & "ref double"
%typemap(cstype) TAPIREAL64 & "ref double"

#%typemap(imtype) ITapTrade::TAPIUINT32 * "ref uint"
#%typemap(cstype) ITapTrade::TAPIUINT32 * "ref uint"
#%typemap(csout) ITapTrade::TAPIUINT32 * "out uint"
#%typemap(imtype) ITapTrade::TAPIUINT32 & "ref uint"
#%typemap(cstype) ITapTrade::TAPIUINT32 & "ref uint"
#
#%typemap(imtype) ITapTrade::TAPIINT32 * "ref int"
#%typemap(cstype) ITapTrade::TAPIINT32 * "ref int"
#%typemap(csout) ITapTrade::TAPIINT32 * "out int"
#%typemap(imtype) ITapTrade::TAPIINT32 & "ref int"
#%typemap(cstype) ITapTrade::TAPIINT32 & "ref int"

#%typemap(imtype) ITapTrade::TAPIINT64 * "ref long"
#%typemap(cstype) ITapTrade::TAPIINT64 * "ref long"
#%typemap(csout) ITapTrade::TAPIINT64 * "out long"
#%typemap(imtype) ITapTrade::TAPIINT64 & "ref long"
#%typemap(cstype) ITapTrade::TAPIINT64 & "ref long"
#
#%typemap(imtype) ITapTrade::TAPIUINT64 * "ref ulong"
#%typemap(cstype) ITapTrade::TAPIUINT64 * "ref ulong"
#%typemap(csout) ITapTrade::TAPIUINT64 * "out ulong"
#%typemap(imtype) ITapTrade::TAPIUINT64 & "ref ulong"
#%typemap(cstype) ITapTrade::TAPIUINT64 & "ref ulong"
#
#%typemap(imtype) ITapTrade::TAPIUINT16 * "ref ushort"
#%typemap(cstype) ITapTrade::TAPIUINT16 * "ref ushort"
#%typemap(csout) ITapTrade::TAPIUINT16 * "out ushort"
#%typemap(imtype) ITapTrade::TAPIUINT16 & "ref ushort"
#%typemap(cstype) ITapTrade::TAPIUINT16 & "ref ushort"
#
#%typemap(imtype) ITapTrade::TAPIUINT8 * "ref char"
#%typemap(cstype) ITapTrade::TAPIUINT8 * "ref char"
#%typemap(csout) ITapTrade::TAPIUINT8 * "out char"
#%typemap(imtype) ITapTrade::TAPIUINT8 & "ref char"
#%typemap(cstype) ITapTrade::TAPIUINT8 & "ref char"
#
#%typemap(imtype) ITapTrade::TAPIREAL64 * "ref double"
#%typemap(cstype) ITapTrade::TAPIREAL64 * "ref double"
#%typemap(csout) ITapTrade::TAPIREAL64 * "out double"
#%typemap(imtype) ITapTrade::TAPIREAL64 & "ref double"
#%typemap(cstype) ITapTrade::TAPIREAL64 & "ref double"

%include "iTapAPICommDef.h"
%include "iTapAPIError.h"
%include "iTapTradeAPIDataType.h"
%include "iTapTradeAPI.h"