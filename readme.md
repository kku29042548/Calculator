# Calculator

by Suphavit Sutthitham,
673450200-7,
Computer and Infomation Science, KKU

# การรับและการแสดงผลข้อมูล

รับข้อมูลจากผู้ใช้งาน และทำงานผ่านการกดปุ่มเพื่อคำนวนตัวเลข

## ปุ่มบวก

```
private void button1_Click(object sender, EventArgs e)
{
    // ข้อความตัวอักษร
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    // convert string to number (integer)
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    // int ทำให้เราสามารถทำการ + - * / ได้
    int iResult = iNum1 + iNum2;
    // ที่ตัวแปรชื่อ result
    // มีคุณสมบัติชื่อ Text
    result.Text = iResult.ToString();
}
```

### รับข้อมูล

```
TextBox num1 = "10"  
TextBox num2 = "5"  

```

### แปลงชนิดของข้อมูล

ตัวอย่าง

```
int iNum1 = Int32.Parse(num1.Text);  // แปลงข้อความเป็นตัวเลข
int iNum2 = Int32.Parse(num2.Text);
```

### คำนวนผลลัพท์

ตัวอย่าง

```
int iResult = iNum1 + iNum2;

```

### แสดงผล

ตัวอย่าง

```
result.Text = iResult.ToString();  // แปลงผลลัพธ์กลับเป็นข้อความเพื่อแสดงผล

```

## ปุ่มลบ
```

private void buttonSubtract_Click(object sender, EventArgs e)
{
    int iNum1 = Int32.Parse(num1.Text);
    int iNum2 = Int32.Parse(num2.Text);
    int iResult = iNum1 - iNum2;
    result.Text = iResult.ToString();
}

```

## ปุ่มคูณ

```
private void button3_Click(object sender, EventArgs e)
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResul = iNum1 * iNum2;
    result.Text = iResul.ToString();
}

```

## ปุ่มหาร

```
private void button4_Click(object sender, EventArgs e)
{
    string inputNum1 = num1.Text;
    string inputNum2 = num2.Text;
    int iNum1 = Int32.Parse(inputNum1);
    int iNum2 = Int32.Parse(inputNum2);
    int iResul = iNum1 / iNum2;
    result.Text = iResul.ToString();
}

```
## ปุ่มลบข้อมูล

```
private void button5_Click(object sender, EventArgs e)
{
    num1.Clear();
    num2.Clear();
    result.Clear();
}

```