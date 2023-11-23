*** Settings ***
Library           Selenium2Library

*** Test Cases ***
Login Test
    Open Browser    https://www.mikrosat.hu    firefox
    Capture Page Screenshot
    Click Element    //*[@id="profile__btn"]
    Input text    //*[@id="shop_user_login"]    email@email.hu
    Input Password    //*[@id="shop_pass_login"]    nagyontitkosjelszo
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

Login Test Win10 Chrome 87
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
    Input text    //*[@id="shop_user_login"]    email@email.com
    Input Password    //*[@id="shop_pass_login"]    jelszo1
    Click Button    //*[contains(text(), "Belép")]
    Wait Until Page Contains    Belépve, mint    20s
    Capture Page Screenshot
    Close Browser

kretateszt
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fresponse_type%3Dcode%26client_id%3Dkreta-eugyintezes-js-web%26state%3DZWh3RzBHWHJNOGphcU5Rbm1acEVQT3pRak1Dem9JaG9ofkhNVGlVdG5MSGtk;%25252Fkerelmek%26redirect_uri%3Dhttps%253A%252F%252Feugyintezes.e-kreta.hu%252Fsignin-oidc%26scope%3Dopenid%2520kreta-eugyintezes-webapi.public%2520kreta-fileservice-webapi.public%26code_challenge%3DTs4vZ2nomGPaVt19MvxqapUgq6DQPDnJU40ZVcUQwJw%26code_challenge_method%3DS256%26nonce%3DZWh3RzBHWHJNOGphcU5Rbm1acEVQT3pRak1Dem9JaG9ofkhNVGlVdG5MSGtk    chrome
    Input Text    //*[@id="UserName"]    72444854161
    Input Text    //*[@id="Password"]    Origins23
    Input Text    //*[@id="login-institute-autocomplete"]/input[1]    Budapesti Gépészeti SZC Katona József Technikum (bgeszc-katona - 203031/011)
    Click Button    //*[@id="submit-btn"]
    Click Button    /html/body/kozelkep-app-root/kozelkep-layout/div/div/main/kozelkep-uzenetek/div/div/div/div[3]/p-button[1]/button

email
    Open Browser    https://login.live.com/login.srf?wa=wsignin1.0&rpsnv=16&ct=1700651415&rver=7.0.6738.0&wp=MBI_SSL&wreply=https%3a%2f%2foutlook.live.com%2fowa%2f%3fcobrandid%3dab0455a0-8d03-46b9-b18b-df2f57b9e44c%26nlp%3d1%26deeplink%3dowa%252f%26RpsCsrfState%3d69e91e52-dd00-126d-c0ad-6d09b2d71db5&id=292841&aadredir=1&CBCXT=out&lw=1&fl=dob%2cflname%2cwld&cobrandid=ab0455a0-8d03-46b9-b18b-df2f57b9e44c    chrome
    Input Text    //*[@id="i0116"]    aron.boldis@katonaj-mkszig.hu
    Capture Page Screenshot
    Click Button    //*[@id="idSIButton9"]
    Capture Page Screenshot
    Click Button    //*[@id="id__220"]
    Capture Page Screenshot
    Input Text    //*[@id="docking_InitVisiblePart_0"]/div/div[3]/div[1]/div/div[4]/div/div/div[1]    "Kiss Zsigmond" <kiss.zsigmond@katonaj-mkszig.hu>
    Input Text    //*[@id="editorParent_1"]/div    Ez egy teszt üzenet
