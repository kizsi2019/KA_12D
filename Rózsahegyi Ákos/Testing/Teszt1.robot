*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Teszt1
    Open Browser    https://www.mikrosat.hu/    Chrome
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input Text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome87
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    87
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 86
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 85
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    85
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 84
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    84
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 83
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    83
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 81
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    81
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 80
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    80
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 79
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    79
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 78
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    78
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 77
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    77
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 76
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    76
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 75
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    75
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 88
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 87
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 86
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 85
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    85
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 84
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    84
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 83
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    83
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 10,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    akos.rozsahegyi@katonaj-mkszig.hu
    Input Password    //*[@id="shop_pass_login"]    Galaxy574.,
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

KretaTeszt
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DtPuxUEFajK_RZr81vaB_lPCT4PZxFnKdHLzt5YnOiwjYllOVUQ8TtdgaB9tv_820_Xsa3ItSQic551KjcXSdNRkylk3FsZSRnesRbiqDN5g_A5E_MwDiGac8p72nlwKKIdasTS_1oqL2BJCMtho0sg%26response_mode%3Dform_post%26nonce%3D638362448441450802.YWFkZmFhMjktMWJiZS00YmUyLWEyOWMtODdmZTA5OWU4YzJjYTFmZmJlNmMtNzFlNy00YjUzLWEyYzEtMWQxOGFhMWY5Njk1%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin
    Input Text    //*[@id="UserName"]    72436541387
    Input Password    //*[@id="Password"]    2003-12-04
    Click Element    //*[@id="submit-btn"]
    Wait Until Page Contains    Rózsahegyi Ákos    20s
    Capture Page Screenshot
    Close Browser

EmailTeszt
    Open Browser    https://www.microsoft.com/hu-hu/microsoft-365/outlook/email-and-calendar-software-microsoft-outlook?deeplink=%2fowa%2f&sdf=0
    Click Element    //*[@id="feature-oc387eee"]/div/div/div[1]/div/div[3]/div[1]/a
    Input Text    //*[@id="i0116"]    akos.rozsahegyi@katonaj-mkszig.hu
    Click Element    //*[@id="idSIButton9"]
    Wait Until Page Contains    Kezdőlap    20s
    Capture Page Screenshot
    Click Element    //*[@id="id__198"]
    Input Text    //*[@id="docking_InitVisiblePart_0"]/div/div[3]/div[1]/div/div[4]/div/div/div[1]    kiss.zsigmond@katonaj-mkszig.hu
    Input Text    //*[@id="TextField729"]    Teszt üzenet
    Input Text    //*[@id="editorParent_1"]/div    Ez egy teszt üzenet
    Click Element    //*[@id="docking_InitVisiblePart_0"]/div/div[2]/div[1]/div/span/button[1]
    Close Browser
