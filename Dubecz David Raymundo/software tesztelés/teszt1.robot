*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt2
    Open Browser    https://www.mikrosat.hu    Edge
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 87
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    87
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 86
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 85
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    85
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 84
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    84
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 83
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    83
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 81
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    81
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 80
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    80
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 79
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    79
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 78
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    78
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 77
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    77
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 76
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    76
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 75
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Chrome
    ${version}=    Set variable    75
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 88
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 87
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 86
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    86
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 85
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    85
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 84
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    84
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    kispista54@gmail.com
    Input Password    //*[@id="shop_pass_login"]    ALMA2244
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Firefox 83
    Set Log level    TRACE
    ${remote_url}=    Set variable    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    ${browser}=    Set variable    Firefox
    ${version}=    Set variable    83
    @{_tmp}    Create List    browserName: ${browser},    platform: Windows 11,    version: ${version},    username: FelhasznaloNev,    accessKey: HozzaferesiKulcs,    name: TeszteljukLe,    build: TeszteljukLe,    idle-timeout: 5400
    ${capabilities}=    Set variable    ${EMPTY.join(${_tmp})}
    ######
    Open browser    https://www.mikrosat.hu    browser=${browser}    remote_url=${remote_url}    desired_capabilities=${capabilities}
    Capture Page Screenshot
    Click Element    //*[@id="UserName"]
    Input text    //*[@id="UserName"]    72365651918
    Input Password    //*[@id="Password"]    2003-06-17
    Click Button    //*[contains(text(), "Bejelentkezés")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Kréta
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253De8wne6WvT0yYs2QWv7Ucg_Jb18pjPOBcazr3oMVLfCNZf879saTqun5J0VXpMxm-W7eYvWzgpaqElG1mHr_Z_wYqrhXqTcqZ8lWVPNA1RpDKjnhWliFitclXWrhayUyFjAH8BAS0xJ0lXcxdY6u5zg%26response_mode%3Dform_post%26nonce%3D638362448906900039.YzFjZmM2NTUtMTI3Yy00NTI2LWFiNGQtYzIzNDIyMDMyMzhkY2M5YzliMGQtYjUxOS00YmYyLWE0YzAtZDg1YzcyNTgzMjY5%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    Edge
    Capture Page Screenshot
    Click Element    //*[@id="UserName"]
    Input text    //*[@id="UserName"]    72365651918
    Input Password    //*[@id="Password"]    2003-06-17
    Click Button    //*[@id="submit-btn"]
    Capture Page Screenshot
    Close Browser

email
    Open Browser    https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=16&ct=1700651784&rver=7.0.6738.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fnlp%3d1%26cobrandid%3dab0455a0-8d03-46b9-b18b-df2f57b9e44c%26RpsCsrfState%3d03b63b70-671f-c89d-2307-d3076914f0ad&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=ab0455a0-8d03-46b9-b18b-df2f57b9e44c    Chrome
    Capture Page Screenshot
    Click Element    //*[@id="i0116"]
    Capture Page Screenshot
    Input text    //*[@id="i0116"]    davidraymundo.dubecz@katonaj-mkszig.hu
    Capture Page Screenshot
    Input Password    //*[@id="i0118"]    UJELu5UhA
    Capture Page Screenshot
    Click Button    //*[@id="idSIButton9"]
    Capture Page Screenshot
    Wait Until Page Contains    New email    20s
    Capture Page Screenshot
    Click Button    //*[@id="innerRibbonContainer"]/div[1]/div/div/div/div[1]/div/div/span/button[1]/span/span[1]
    Capture Page Screenshot
    Close Browser
