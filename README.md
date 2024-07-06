# CS511_QLNS
**Project’s Title:** Bookstore management application

**Logo:** <br> <br>
![TheGreenBook](https://github.com/SBPhungNguyen/CS511_QLNS_DoAn/assets/145269191/193ed747-db5a-4f82-9505-21f46ce9a2f2)


**Contributors:** <br>
- Nguyễn Đặng Kim Phụng – 22521148 – [GitHub](https://github.com/SBPhungNguyen)

**Supervisor:** <br>
- M.Sc. Nguyễn Bích Vân

**Video Demo:** [LinkVideo](https://www.youtube.com/watch?v=V8B3tfDVuQQ&ab_channel=PK)

**Description:** <br>
- This is a comprehensive bookstore management application designed to simplify your operations and boost your bottom line.

**Key Features:** <br>
- Browse with Ease: Discover new reads with targeted advertising and browse books by genre. <br>
- Engage with the Community: Leave comments and share your thoughts on your favorite books. <br>
- Effortless Purchasing: Add books to your cart and purchase them securely within the app. <br>
- Convenient Delivery: Receive a QR code via email after your purchase for easy order tracking or in-store pickup. <br>
- Receipt at Your Fingertips: Scan the QR code in your email to access your receipt details anytime. <br>
-	Live Chat Support: Need help finding a book or have questions? Chat with a bookstore employee in real-time. <br>
-	Reporting & Analytics: Gain valuable insights into general and revenues, sales trends and customer behavior with insightful reports. <br>
-	User-friendly Interface: Navigate the app with ease using a modern and intuitive design. <br>

**Prerequisites:**
-	A device with SQL Server installed. Download options for various SQL Server versions can be found on the official Microsoft website: https://www.microsoft.com/en-us/sql-server/sql-server-downloads <br>
-	Access to the application's public code repository. <br>

**Database Configuration:**
-	**Repository Access:** Firstly, it is essential to ascertain that the repository is configured with a public status. Given that our repository is an open-source project belonging to us, it has been predominantly designated as public.
- **Code Download:** Navigate to the main repository page and locate the "Code" button. From the dropdown menu, select "Download ZIP" to download the application's source code as a compressed archive.
-	**File Extraction:** Unzip the downloaded archive on your device.
-	**Data Directory** Configuration: Locate the "Important Folder" directory within the extracted files. Copy the subdirectories "Emp_Pic" and "Pic" to the D drive on your device. Alternatively, if you choose a different destination drive, ensure the paths in the application's connection string file (connection.cs) are updated accordingly.
-	**Database Import:** 
> -	Open SQL Server Management Studio and right-click on the "Databases" node.
> -	Select "Import Data-tier Application" from the context menu.
> -	Click "Next" on the "Introduction" page.
> - In the "Import Setting" window, choose "Import from Local Disk".
> -	Click "Browse" and locate the "DB_CS511.bacpac" file within the "Important Folder" directory. Click "Next" after selecting the file.
> -	Accept the default settings in the "Database Settings" window by clicking "Next" on each subsequent page.
> -	Wait for the database import process to complete. Once finished, click "Close".
-	**Server Name Retrieval:** 
> - In SQL Server Management Studio, locate the server name by right-clicking on the topmost node in the left-hand menu and selecting "Properties".
> - The server name will be displayed in the "Name" field in the "Properties" window.

**Application Configuration:**
-	**Project Launch:** Double-click the "CS511_Project_QLNS.sln" file to launch the application's development environment (Design Mode).
-	**Database Connection:** 
> -	Navigate to the "Tools" menu and select "Connect to Database...".
> -	In the connection window, verify that "Microsoft SQL Server (SqlClient)" is selected as the data source and "Encrypt" is set to "Optional (false)".
> -	Paste the server name obtained in the previous step into the "Server name" field.
> - In the "Select or enter a database name" field, enter "DB_CS511".
-	**Advanced Configuration:** 
> -	Click the "Advanced..." button in the bottom right corner of the connection window.
> - Copy the entire line displayed at the bottom of the newly opened window.
-	**Connection Test:** Click "Test Connection". If the configuration is successful, a notification will appear confirming a successful connection test.
-	**Confirmation:** Click "OK" to finalize the connection setup. The application is now ready to be executed.

**Additional Information:**

**Code of Conducting:**
-	**Educational Purposes Only:** This software is intended for educational purposes. Users are expected to use it solely in academic and learning settings to better understand keylogger technology. Any usage intended for other purposes is strictly forbidden.
- **No Malicious Intent:** Under no circumstances should this software be used for any malicious activities, including unauthorized access to private information, invasion of privacy, or any other unethical practices. Usages for Malicious Intent will not only go against our Code Of Conduct but are also Illegal.
-	**Accountability and Informed Consent:** Users must acknowledge full accountability for the consequences arising from the use of this software, whether intentional or unintentional. Before usage, it is vital to obtain informed consent from all parties involved in any demonstrations. Respect the privacy and legal rights of others.
-	**Local Laws and Regulations:** Users are responsible for complying with all applicable local laws and regulations regarding the use of this software. Be aware of and respect the legal implications of utilizing keylogger functionality.
-	**No Inter-device Usage:** This software is designed to be used on a single device for educational purposes. Do not attempt to modify it to be used between multiple devices or in any way that extends beyond the boundaries of the intended educational context.

**License:** <br>
Copyright 2024, CS511_QLNS_DoAn Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
