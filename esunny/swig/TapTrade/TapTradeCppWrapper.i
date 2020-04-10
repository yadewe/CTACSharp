%module TapTradeCppWrapper
%{
#include "iTapAPICommDef.h"
#include "iTapAPIError.h"
#include "iTapTradeAPIDataType.h"
#include "iTapTradeAPI.h"
%}


%typemap(imtype) ITapTrade::TAPIUINT32 * "out uint"
%typemap(cstype) ITapTrade::TAPIUINT32 * "out uint"
%typemap(csout) ITapTrade::TAPIUINT32 * "out uint"
%typemap(imtype) ITapTrade::TAPIUINT32 & "out uint"
%typemap(cstype) ITapTrade::TAPIUINT32 & "out uint"

%typemap(imtype) ITapTrade::TAPIINT32 * "out int"
%typemap(cstype) ITapTrade::TAPIINT32 * "out int"
%typemap(csout) ITapTrade::TAPIINT32 * "out int"
%typemap(imtype) ITapTrade::TAPIINT32 & "out int"
%typemap(cstype) ITapTrade::TAPIINT32 & "out int"

%typemap(imtype) ITapTrade::TAPIINT64 * "out long"
%typemap(cstype) ITapTrade::TAPIINT64 * "out long"
%typemap(csout) ITapTrade::TAPIINT64 * "out long"
%typemap(imtype) ITapTrade::TAPIINT64 & "out long"
%typemap(cstype) ITapTrade::TAPIINT64 & "out long"

%typemap(imtype) ITapTrade::TAPIUINT64 * "out ulong"
%typemap(cstype) ITapTrade::TAPIUINT64 * "out ulong"
%typemap(csout) ITapTrade::TAPIUINT64 * "out ulong"
%typemap(imtype) ITapTrade::TAPIUINT64 & "out ulong"
%typemap(cstype) ITapTrade::TAPIUINT64 & "out ulong"

%typemap(imtype) ITapTrade::TAPIUINT16 * "out ushort"
%typemap(cstype) ITapTrade::TAPIUINT16 * "out ushort"
%typemap(csout) ITapTrade::TAPIUINT16 * "out ushort"
%typemap(imtype) ITapTrade::TAPIUINT16 & "out ushort"
%typemap(cstype) ITapTrade::TAPIUINT16 & "out ushort"

%typemap(imtype) ITapTrade::TAPIUINT8 * "out char"
%typemap(cstype) ITapTrade::TAPIUINT8 * "out char"
%typemap(csout) ITapTrade::TAPIUINT8 * "out char"
%typemap(imtype) ITapTrade::TAPIUINT8 & "out char"
%typemap(cstype) ITapTrade::TAPIUINT8 & "out char"

%typemap(imtype) ITapTrade::TAPIREAL64 * "out double"
%typemap(cstype) ITapTrade::TAPIREAL64 * "out double"
%typemap(csout) ITapTrade::TAPIREAL64 * "out double"
%typemap(imtype) ITapTrade::TAPIREAL64 & "ref double"
%typemap(cstype) ITapTrade::TAPIREAL64 & "out double"

%typemap(imtype) ITapTrade::TAPISTR_50 * "string"
%typemap(cstype) ITapTrade::TAPISTR_50 * "string"
%typemap(csout) ITapTrade::TAPISTR_50 * "string"
%typemap(imtype) ITapTrade::TAPISTR_50 & "string"
%typemap(cstype) ITapTrade::TAPISTR_50 & "string"

%include "iTapAPICommDef.h"
%include "iTapAPIError.h"
%include "iTapTradeAPIDataType.h"
%include "iTapTradeAPI.h"