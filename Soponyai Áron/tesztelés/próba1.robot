*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt1
    Open browser    https://www.mikrosat.hu    chrome
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]
    Input Text    //*[@id="shop_user_login"]    email
    Input Text    //*[@id="shop_pass_login"]    jelszo
    Click Element    //*[@id="container"]/header/div/div/div[2]/div/div[2]/div[3]/div/div[2]/form/div[1]/button
    Close browser

ep18
    Open Browser \ \ \    https://www.mikrosat.hu    chrome
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \    //*[@id="profile__btn"]
    \ \ \ Input text \ \    //*[@id="shop_user_login"] \ \ \    email@email.hu
    \ \ \ Input Password \ \    //*[@id="shop_pass_login"] \ \ \    nagyontitkosjelszo
    \ \ \ Click Button \ \ \    //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \    Belépve, mint \ \ \    20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser

ep19
    *** Test Cases ***
    \ \ Open Browser \    https://www.mikrosat.hu \ \ \    chrome
    \ \ \ Capture Page Screenshot
    \ \ Click Element \ \    //*[@id="profile__btn"]
    \ \ Input text \ \ \    //*[@id="shop_user_login"] \ \ \    email@email.hu
    \ \ Input Password \ \ \ \ \ \    //*[@id="shop_pass_login"]    nagyontitkosjelszo
    \ \ Click Button \ \    //*[contains(text(), "Belép")]
    \ \ Wait Until Page Contains \ \ \    Belépve, mint \ \ \    20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    \ \ Set Log level \ \ \    TRACE
    \ \ ${remote_url}= \ \ \    Set variable \ \ \    https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ ${browser}= \ \ \    Set variable \ \ \    Chrome
    \ \ ${version}= \ \ \ \ \ \ \    Set variable    87
    \ @{_tmp} \ \ \ \ \ \    Create List \ \    browserName: ${browser}, \ \ \    platform: Windows 10, \ \ \    version: ${version}, \ \ \    username: FelhasznaloNev, \ \ \    accessKey: HozzaferesiKulcs,    name: TeszteljukLe, \ \ \    build: TeszteljukLe, \ \ \    idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 86
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 86
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 85
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 85
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 84
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 84
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 83
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 83
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 81
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 81
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 80
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 80
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 79
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 79
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 78
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 78
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 77
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 77
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 76
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 76
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Chrome 75
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Chrome
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 75
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 88
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 86
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 87
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 86
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 86
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 86
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 85
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 85
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 84
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 84
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser
    Login Test Win10 Firefox 83
    \ \ \ Set Log level \ \ \ TRACE
    \ \ \ ${remote_url}= \ \ \ Set variable \ \ \ https://ondemand.eu-central-1.saucelabs.com/wd/hub
    \ \ \ ${browser}= \ \ \ Set variable \ \ \ Firefox
    \ \ \ ${version}= \ \ \ Set variable \ \ \ 83
    \ \ \ @{_tmp} \ \ \ Create List \ \ \ browserName: ${browser}, \ \ \ platform: Windows 10, \ \ \ version: ${version}, \ \ \ username: FelhasznaloNev, \ \ \ accessKey: HozzaferesiKulcs, \ \ \ name: TeszteljukLe, \ \ \ build: TeszteljukLe, \ \ \ idle-timeout: 5400
    \ \ \ ${capabilities}= \ \ \ Set variable \ \ \ ${EMPTY.join(${_tmp})}
    \ \ \    ######
    \ \ \ Open browser \ \ \ https://www.mikrosat.hu \ \ \ browser=${browser} \ \ \ remote_url=${remote_url} \ \ \ desired_capabilities=${capabilities}
    \ \ \ Capture Page Screenshot
    \ \ \ Click Element \ \ \ //*[@id="profile__btn"]
    \ \ \ Input text \ \ \ //*[@id="shop_user_login"] \ \ \ email@email.hu
    \ \ \ Input Password \ \ \ //*[@id="shop_pass_login"] \ \ \ nagyontitkosjelszo
    \ \ \ Click Button \ \ \ //*[contains(text(), "Belép")]
    \ \ \ Wait Until Page Contains \ \ \ Belépve, mint \ \ \ 20s
    \ \ \ Capture Page Screenshot
    \ \ \ Close Browser

kréta
    open browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253DklxCXgNMBbHx_o2LdqSLFWRrFqYoycl58xn9vsuzGPYi45uUmLUXpuYnsPJ5Ctm9s9W7LB8YpQKeMLKU1Qegt31Woe2CNXczt-lFGYIa3lmXQvsst0a2xOXFeuBPRZvdqY8ut16tBJfPAuuvGNhWcg%26response_mode%3Dform_post%26nonce%3D638362478480030582.YzJmZTlkZjYtZGE4YS00ZTY3LWI1ODktNDc2NDEyZDVlNzE0OWE0MGI0YzMtMThkZC00NDQ3LWFjYmEtNDM4YWRjZWMwNWI0%26institute_code%3Dbgeszc-katona%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbgeszc-katona.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    chrome
    input text    //*[@id="UserName"]    72440669512
    input text    //*[@id="Password"]    2004-08-01
    click element    //*[@id="submit-btn"]
    Capture Page Screenshot
    close browser

outlook
    open browser    https://login.microsoftonline.com/organizations/oauth2/v2.0/authorize?client_id=5e3ce6c0-2b1f-4285-8d4b-75ee78787346&scope=https%3A%2F%2Fapi.spaces.skype.com%2F.default%20openid%20profile%20offline_access&redirect_uri=https%3A%2F%2Fteams.microsoft.com%2Fgo&client-request-id=f64f6fd5-18ae-44dc-b644-972e4f29806d&response_mode=fragment&response_type=code&x-client-SKU=msal.js.browser&x-client-VER=2.19.0&x-client-OS=&x-client-CPU=&client_info=1&code_challenge=WR0KJxy-axKoP0F9gbzVhJiizUMppGSakajrBVw4lU4&code_challenge_method=S256&nonce=0f815947-ec80-41f4-b275-5ba09796f95f&state=eyJpZCI6IjU2ZjY0N2JiLWFkZjAtNGFhZC04OGE1LTIyNTFjOWU4Mjk0MCIsIm1ldGEiOnsiaW50ZXJhY3Rpb25UeXBlIjoicmVkaXJlY3QifX0%3D&claims=%7B"access_token"%3A%7B"xms_cc"%3A%7B"values"%3A%5B"CP1"%5D%7D%7D%7D    chrome
    Sleep    5s
    input text    //*[@id="i0116"]    aron.soponyai@katonaj-mkszig.hu
    click element    //*[@id="idSIButton9"]
    Sleep    5s
    input text    //*[@id="i0118"]    CSoport55
    click element    //*[@id="idSIButton9"]
    Sleep    5s
    click button    //*[@id="idBtn_Back"]
    sleep    10s
    click element    //*[@id="tilesHolder"]/div[1]/div/div[1]
    wait until page contains    Naptár    30s
    sleep    10s
    click button    //*[@id="app-bar-86fcd49b-61a2-4701-b771-54728cd291fb"]
    sleep    10s
    click element    //*[@id="chatstab"]/div/div/chat-list-bridge/div/div[1]/div/ul/li[2]/div[2]/div[1]/a
    sleep    20s
    input text    //*[@id="new-message-a8e84b17-ab51-4e59-b79c-f2683d1d3806"]/p    automatizált üzenet próba
    click button    //*[@id="message-pane-layout-a11y"]/div[3]/div/div[4]/div[2]/div[3]/div/button

            EZ EGY AUTOMATIZÁLT ÜZETENET EZ EGY AUTOMATIZÉLT ÜZENET





