# **LinguaLearn - Complete Language Learning Suite**  
**Version 1.0**  

---

## **📌 Table of Contents**  
1. [**Overview**](#-overview)  
2. [**Key Features**](#-key-features)  
3. [**Technical Implementation**](#-technical-implementation)  
4. [**Forms & Functionalities**](#-forms--functionalities)  
   - [Program.cs](#programcs)  
   - [Form1.cs to Form4.cs](#form1cs-to-form4cs)  
   - [Form5.cs (TTS Module)](#form5cs-tts-module)  
   - [Form6.cs (Translator)](#form6cs-translator)  
   - [Form7.cs (Video Player)](#form7cs-video-player)  
   - [Form8.cs (Main Dashboard)](#form8cs-main-dashboard)  
   - [Form9.cs & Form10.cs (Language Selection)](#form9cs--form10cs-language-selection)  
   - [Form11.cs (PDF Viewer)](#form11cs-pdf-viewer)  
   - [Form12.cs (Vocabulary Trainer)](#form12cs-vocabulary-trainer)  
   - [Form13.cs (Progress Tracker)](#form13cs-progress-tracker)  
5. [**Installation & Setup**](#-installation--setup)  
6. [**Usage Guide**](#-usage-guide)    
7. [**Support & Contact**](#-support--contact)
8. .[**License**](#License)
9. .[**Contributors**](#Contributors)

---

## **🌐 Overview**  
LinguaLearn is a **Windows Forms-based language learning application** built with **C#**. It integrates:  
- **Text-to-Speech (TTS)** for pronunciation  
- **Real-time translation** via Google Translate API  
- **Multimedia learning** (PDFs, videos)  
- **Progress tracking** across modules  

Target Audience: Language learners, educators, and travelers.  

---

## **✨ Key Features**  
| **Feature**               | **Description**                                                                 |
|---------------------------|-------------------------------------------------------------------------------|
| **Multi-Language TTS**    | Supports 100+ languages with adjustable voice gender/age (Form5)             |
| **Smart Translator**      | Uses Google Translate API with language auto-detection (Form6)               |
| **Video Learning**        | Embedded media player for interactive lessons (Form7)                        |
| **Vocabulary Builder**    | Generates translated word lists with TTS pronunciation (Form12)              |
| **Progress Analytics**    | Tracks usage time across modules (Forms 3/5/6/12 → Form13)                   |
| **PDF Integration**       | Reads language textbooks/worksheets (Form11)                                 |

---

## **💻 Technical Implementation**  
### **Core Technologies**  
- **.NET Framework 4.7.2+**  
- **System.Speech.Synthesis** (TTS)  
- **Google Translate API** (HTTP requests)  
- **AxWindowsMediaPlayer** (Video playback)  
- **PDF Viewer Control** (Syncfusion/Adobe)  

### **Architecture**  
- **Frontend**: Windows Forms (C#)  
- **Backend**: Google Translate API (stateless HTTP)  
- **Data Flow**:  
  ```mermaid
  graph LR
    A[Form9/10: Language Selection] --> B[Form6: Translator]
    A --> C[Form5: TTS]
    A --> D[Form12: Vocabulary]
    B/C/D --> E[Form13: Progress Aggregation]
  ```

---

## **📋 Forms & Functionalities**  

## Project Structure
```
├── LinguaLearn,
|   ├── Lingualearn,
|      ├── Packages,
|      ├── Lingualearn,
│         ├── Account.cs
│         ├── Form1.cs
│         ├── Form2.cs
│         ├── Form3.cs
│         ├── Form4.cs
│         ├── Form5.cs
│         ├── Form6.cs
│         ├── Form7.cs
│         ├── Form8.cs
│         ├── Form9.cs
│         ├── Form10.cs
│         ├── Form11.cs
│         ├── Form12.cs
│         ├── Form13.cs
│         ├── Program.cs
│   ├── Documentation (contains user manual and design docs),
|      ├── LinguaLearn.pptx
|      ├── LinguaLearn_Docs1
|      ├── LinguaLearn_Docs2
|      ├── LinguaLearn_Docs3
│   ├── README.md
```


### **Program.cs**  
- **Entry point**: Initializes `Form8` (Main Dashboard).  
- **Key Code**:  
  ```csharp
  Application.Run(new Form8()); // Starts the application
  ```

### **Form1.cs to Form4.cs**  
- **Form1.cs**: The First page.  
- **Form2.cs**: user registration.  
- **Form3.cs**: Contains `ff3` progress variable (referenced in Form13).  
- **Form4.cs**: Text to Audio/speech.  

### **Form5.cs (TTS Module)**  
- **Features**:  
  - Language dropdown with culture-specific voices.  
  - Async playback with pause/resume.  
- **Key Code**:  
  ```csharp
  speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 0, new CultureInfo("fr-FR")); // French example
  speech.SpeakAsync("Bonjour");
  ```

### **Form6.cs (Translator)**  
- **Workflow**:  
  1. User selects `from`/`to` languages.  
  2. Input text → Google API → Translated output.  
- **API Call**:  
  ```csharp
  string url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={from}&tl={to}&q={text}";
  ```

### **Form7.cs (Video Player)**  
- Auto-plays `Lingualearn.mp4` on load.  
- Uses `AxWindowsMediaPlayer` control.  

### **Form8.cs (Main Dashboard)**  
- **Navigation Buttons**:  
  ```csharp
  rjButton5.Click --> Form5 (TTS)
  rjButton6.Click --> Form12 (Vocabulary)
  rjButton7.Click --> Form11 (PDF)
  ```

### **Form9.cs & Form10.cs (Language Selection)**  
| **Variable** | **Type** | **Example** | **Purpose** |
|-------------|---------|------------|------------|
| `t1`        | `string` | `"es"`     | Native language code |
| `your`      | `string` | `"Spanish"`| Native language name |
| `t2`        | `string` | `"de"`     | Target language code |
| `learn`     | `string` | `"German"` | Target language name |

### **Form11.cs (PDF Viewer)**  
- Uses `OpenFileDialog` to load PDFs:  
  ```csharp
  OpenFileDialog opf = new OpenFileDialog();
  opf.Filter = "PDF Files|*.pdf";
  pdfViewer1.LoadFromFile(opf.FileName);
  ```

### **Form12.cs (Vocabulary Trainer)**  
- Translates 30 lines of text into target/native languages.  
- TTS integration for pronunciation.  

### **Form13.cs (Progress Tracker)**  
- Aggregates progress from:  
  ```csharp
  progressBar1.Value = Form3.ff3 + Form5.ff4 + Form6.ff5 + Form12.ff6;
  ```

---

## **🛠️ Installation & Setup**  
### **Requirements**  
- Windows 10/11  
- .NET Framework 4.7.2+  
- Internet connection (for translation/TTS)  

### Step 1: Install Visual Studio
If you haven’t installed Visual Studio, download and install it from [Visual Studio Download](https://visualstudio.microsoft.com/downloads/).

### Step 2: Install .NET App Development Module
1. Open Visual Studio Installer.
2. Navigate to **Modify > Individual Components**.
3. Check **.NET Desktop Development**.
4. Click **Modify** to install.

### Step 3: Clone the Repository
Download or clone the repository from GitHub using the following command:
```sh
 git clone https://github.com/SahilKumar775/LinguaLearn.git
```
Alternatively, you can manually download the ZIP file and extract it.

### Step 4: Open the Project in Visual Studio
1. Launch Visual Studio.
2. Click **Continue without code**.
3. Open the extracted folder by navigating to **File > Open > Folder**.
4. Double-click `Program.cs` to open the main entry file.

### Step 5: Run the Application
1. Click on the **Run** button in Visual Studio.
2. The application will launch, and you can start using its features.
---

## **📖 Usage Guide**  
1. **Set Languages**:  
   - Open `Form9` → Select native language.  
   - Open `Form10` → Select target language.  
2. **Use Features**:  
   - **TTS (Form5)**: Type text → Select language → Play.  
   - **Translator (Form6)**: Enter text → Translate.  
   - **Vocabulary (Form12)**: View translated word lists.  
3. **Track Progress**:  
   - Check `Form13` for cumulative usage analytics.  

---

## **📧 Support & Contact**  
For assistance:  
1. **Describe**: Form where issue occurred.  
2. **Steps**: How to reproduce.  
3. **Screenshots**: If applicable.  
**Email**: sahil.kumar.r516@gmail.com
If you encounter any issues while using LinguaLearn, our support team is here to assist you!

--- 

## **📜 License**

This project is licensed under the **MIT License**.  
See the [LICENSE](LICENSE) file for details.

---

## **✨ Contributors**

1. **Sahil Kumar**
2. **Meher Amir**
3. **Rahia Adnan**
