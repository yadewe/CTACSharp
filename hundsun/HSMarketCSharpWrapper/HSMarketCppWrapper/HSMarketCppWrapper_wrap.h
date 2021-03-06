/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.12
 *
 * This file is not intended to be easily readable and contains a number of
 * coding conventions designed to improve portability and efficiency. Do not make
 * changes to this file unless you know what you are doing--modify the SWIG
 * interface file instead.
 * ----------------------------------------------------------------------------- */

#ifndef SWIG_HSMarketCppWrapper_WRAP_H_
#define SWIG_HSMarketCppWrapper_WRAP_H_

class SwigDirector_CHSMdSpi : public CHSMdSpi, public Swig::Director {

public:
    SwigDirector_CHSMdSpi();
    virtual void OnFrontConnected();
    virtual void OnFrontDisconnected(int nResult);
    virtual void OnRspDepthMarketDataSubscribe(CHSRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
    virtual void OnRspDepthMarketDataCancel(CHSRspInfoField *pRspInfo, int nRequestID, bool bIsLast);
    virtual void OnRtnDepthMarketData(CHSDepthMarketDataField *pDepthMarketData);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef void (SWIGSTDCALL* SWIG_Callback1_t)(int);
    typedef void (SWIGSTDCALL* SWIG_Callback2_t)(void *, int, unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback3_t)(void *, int, unsigned int);
    typedef void (SWIGSTDCALL* SWIG_Callback4_t)(void *);
    void swig_connect_director(SWIG_Callback0_t callbackOnFrontConnected, SWIG_Callback1_t callbackOnFrontDisconnected, SWIG_Callback2_t callbackOnRspDepthMarketDataSubscribe, SWIG_Callback3_t callbackOnRspDepthMarketDataCancel, SWIG_Callback4_t callbackOnRtnDepthMarketData);

private:
    SWIG_Callback0_t swig_callbackOnFrontConnected;
    SWIG_Callback1_t swig_callbackOnFrontDisconnected;
    SWIG_Callback2_t swig_callbackOnRspDepthMarketDataSubscribe;
    SWIG_Callback3_t swig_callbackOnRspDepthMarketDataCancel;
    SWIG_Callback4_t swig_callbackOnRtnDepthMarketData;
    void swig_init_callbacks();
};

class SwigDirector_CHSMdApi : public CHSMdApi, public Swig::Director {

public:
    SwigDirector_CHSMdApi();
    virtual void ReleaseApi();
    virtual int Init(char const *pszLicFile, char const *pszPwd = "", char const *pszSslFile = "", char const *pszSslPwd = "");
    virtual int Join();
    virtual int RegisterFront(char const *pszFrontAddress);
    virtual int RegisterFensServer(char const *pszFensAddress, char const *pszAccountID);
    virtual void RegisterSpi(CHSMdSpi *pSpi);
    virtual int ReqDepthMarketDataSubscribe(CHSReqDepthMarketDataField pReqDepthMarketDataSubscribe[], int nCount, int nRequestID);
    virtual int ReqDepthMarketDataCancel(CHSReqDepthMarketDataField pReqDepthMarketDataCancel[], int nCount, int nRequestID);
    virtual char const *GetApiErrorMsg(int nErrorCode);

    typedef void (SWIGSTDCALL* SWIG_Callback0_t)();
    typedef int (SWIGSTDCALL* SWIG_Callback1_t)(char *, char *, char *, char *);
    typedef int (SWIGSTDCALL* SWIG_Callback2_t)(char *, char *, char *);
    typedef int (SWIGSTDCALL* SWIG_Callback3_t)(char *, char *);
    typedef int (SWIGSTDCALL* SWIG_Callback4_t)(char *);
    typedef int (SWIGSTDCALL* SWIG_Callback5_t)();
    typedef int (SWIGSTDCALL* SWIG_Callback6_t)(char *);
    typedef int (SWIGSTDCALL* SWIG_Callback7_t)(char *, char *);
    typedef void (SWIGSTDCALL* SWIG_Callback8_t)(void *);
    typedef int (SWIGSTDCALL* SWIG_Callback9_t)(void *, int, int);
    typedef int (SWIGSTDCALL* SWIG_Callback10_t)(void *, int, int);
    typedef char * (SWIGSTDCALL* SWIG_Callback11_t)(int);
    void swig_connect_director(SWIG_Callback0_t callbackReleaseApi, SWIG_Callback1_t callbackInit__SWIG_0, SWIG_Callback2_t callbackInit__SWIG_1, SWIG_Callback3_t callbackInit__SWIG_2, SWIG_Callback4_t callbackInit__SWIG_3, SWIG_Callback5_t callbackJoin, SWIG_Callback6_t callbackRegisterFront, SWIG_Callback7_t callbackRegisterFensServer, SWIG_Callback8_t callbackRegisterSpi, SWIG_Callback9_t callbackReqDepthMarketDataSubscribe, SWIG_Callback10_t callbackReqDepthMarketDataCancel, SWIG_Callback11_t callbackGetApiErrorMsg);

private:
    SWIG_Callback0_t swig_callbackReleaseApi;
    SWIG_Callback1_t swig_callbackInit__SWIG_0;
    SWIG_Callback2_t swig_callbackInit__SWIG_1;
    SWIG_Callback3_t swig_callbackInit__SWIG_2;
    SWIG_Callback4_t swig_callbackInit__SWIG_3;
    SWIG_Callback5_t swig_callbackJoin;
    SWIG_Callback6_t swig_callbackRegisterFront;
    SWIG_Callback7_t swig_callbackRegisterFensServer;
    SWIG_Callback8_t swig_callbackRegisterSpi;
    SWIG_Callback9_t swig_callbackReqDepthMarketDataSubscribe;
    SWIG_Callback10_t swig_callbackReqDepthMarketDataCancel;
    SWIG_Callback11_t swig_callbackGetApiErrorMsg;
    void swig_init_callbacks();
};


#endif
