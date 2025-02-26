# OrderMenuPractice

這個專案是一個使用 Windows Forms (WinForms) 開發的簡易點餐介面，旨在練習 C# 程式設計和基本設計模式。專案實現了餐點選擇、總金額計算以及特價套用的功能，適合初學者學習和參考。

## 功能
- **餐點選擇**：使用者可以從清單中挑選餐點。
- **總金額計算**：自動計算所選餐點的總價。
- **特價套用**：根據特定條件應用折扣或優惠。

## 技術棧
- **語言**：C#
- **框架**：Windows Forms (WinForms)
- **設計模式**：工廠模式 (Factory Pattern)
- **架構**：採用由上至下傳遞資料的方式，確保程式邏輯清晰。

## 安裝與執行
1. 確保你的系統已安裝 [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)（建議 4.8 或以上）。
2. 複製此倉庫：git clone https://github.com/[你的GitHub用戶名]/OrderMenuPractice.git
3. 使用 Visual Studio 開啟 `.sln` 檔案。
4. 按 F5 或點擊「啟動」運行程式。

## 使用說明
1. 啟動程式後，會顯示一個點餐介面。
2. 在菜單中選擇你想要的餐點。
3. 查看右側顯示的總金額。
4. 若符合條件，可點擊「套用特價」按鈕享受優惠。

## 專案結構
- **Form1.cs**：主介面，負責顯示和使用者互動。
- **Factories/**：工廠模式的實現，用於生成餐點物件。
- **Models/**：定義餐點資料結構，資料從上往下傳遞。

## 備註
這是一個練習專案，歡迎提出建議或改進想法！
