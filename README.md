# encryption-algorithm

[![star this repo](http://githubbadges.com/star.svg?user=usecodelee&repo=encryption-algorithm&style=flat)](https://github.com/usecodelee/encryption-algorithm)
[![fork this repo](http://githubbadges.com/fork.svg?user=usecodelee&repo=encryption-algorithm&style=flat)](https://github.com/usecodelee/encryption-algorithm/fork) ![](https://img.shields.io/badge/language-C%23-yellowgreen.svg) ![](https://img.shields.io/badge/C%23-81.5%25-orange.svg) ![](https://img.shields.io/badge/SHOW-GUI-red.svg) ![](https://img.shields.io/badge/license-MIT-blue.svg)  

各种密码学算法的 C# GUI编程实现，包含：  

1. DES  
2. AES  
3. Present  
4. 扩展欧几里得算法  
5. 素性检测  

## 最终的结果

> **DES加密**  

![DES加密](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/desjia.png)

> **DES解密**  

![DES解密](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/desjian.png)

> **AES加解密**  

![AES加解密](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/aes.png)

> **Present**  

![Present](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/parent.png)

> **扩展欧几里得算法**  

![扩展欧几里得算法](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/Euclidean.png)

> **素性检测**  

![素性检测](https://github.com/usecodelee/encryption-algorithm/blob/master/imgs/Miller-Rabin.png)

## 使用说明（输入输出）

> 建议使用`visual studio 2015`打开此项目（解决方案）。

### 1. DES加密

点击DES选项卡选择**DES**加密 --> 在原文的位置输入需要加密的内容（也可以点击**文件加密**选择需要加密的文件）--> 输入**8位**密钥 --> 点击加密按钮 --> 密文的位置会显示加密后的内容  
> 左下角会显示加密所用时间
> 右下角的导出按钮可以导出加密后的密文

### 2. DES解密

具体操作方法和DES加密类似。

### 3. AES加密

点击顶部选项卡中的**AES** --> 选择密钥长度（128bits/192bits/256bits） --> 在明文的位置输入需要加密的内容（也可以点击**打开加密文件**选择需要加密的文件） --> 输入**16位**密钥 --> 点击**生成密钥**生成扩展密钥 --> 点击加密按钮 --> 密文的位置会显示加密后的内容  
> 左下角会显示加密所用时间
> 右下角的导出按钮可以导出加密后的密文
> 可以在扩展密钥弹窗中看见扩展密钥
> 可以在加解密过程弹窗中看见加解密过程

### 4. AES解密

具体操作方法和加密类似。

### 5. Present轻量级加密算法加密

点击顶部选项卡中的**Present** --> 输入明文（**16位**，也可以点击**打开加密文件**选择需要加密的文件） --> 输入密钥（**20位**） --> 点击加密 --> 密文的位置会显示加密后的内容  
> 左下角会显示加密所用时间
> 右下角的导出按钮可以导出加密后的密文

### 6. 扩展欧几里得算法

相当于一个乘法逆元计算器。  
点击顶部的**扩展欧几里得算法** --> 第一个数输入需要计算的数 --> 在**模**的位置输入‘模’ --> 点击确定 --> 可以在下方看见计算结果  

### 7. 素性检测

点击顶部选项卡中的**Miller-Robin** --> 在第一个输入框和第二个输入框都输入同一个需要被判定的数 --> 分别点击计算 --> 可以看见计算结果  
> 下面的普通方式是使用**输入的数**去除**1到输入的数-1**的所有数
> 可以查看使用两种方式判断素数的性能差别

## 算法介绍

### 1. DES

DES全称为Data Encryption Standard，即数据加密标准，是一种使用密钥加密的块算法。  

#### DES基本原则

DES设计中使用了分组密码设计的两个原则：混淆（`confusion`）和扩散(`diffusion`)，其目的是抗击敌手对密码系统的统计分析。混淆是使密文的统计特性与密钥的取值之间的关系尽可能复杂化，以使密钥和明文以及密文之间的依赖性对密码分析者来说是无法利用的。扩散的作用就是将每一位明文的影响尽可能迅速地作用到较多的输出密文位中，以便在大量的密文中消除明文的统计结构，并且使每一位密钥的影响尽可能迅速地扩展到较多的密文位中，以防对密钥进行逐段破译。  

#### DES算法步骤

DES算法把64位的明文输入块变为64位的密文输出块,它所使用的密钥也是64位（实际用到了56位，第8、16、24、32、40、48、56、64位是校验位， 使得每个密钥都有奇数个1），其算法主要分为两步：  

1）初始置换  

其功能是把输入的64位数据块按位重新组合，并把输出分为`L0`、`R0`两部分，每部分各长32位，其置换规则为将输入的第58位换到第一位,第50位换到第2位……依此类推,最后一位是原来的第7位。`L0`、`R0`则是换位输出后的两部分，`L0`是输出的左32位，`R0`是右32位,例:设置换前的输入值为`D1D2D3……D64`,则经过初始置换后的结果为:`L0=D58D50……D8`;`R0=D57D49……D7`。  

其置换规则见下表：  

58,50,42,34,26,18,10,2,  
60,52,44,36,28,20,12,4,  
62,54,46,38,30,22,14,6,  
64,56,48,40,32,24,16,8,  
57,49,41,33,25,17,9,1,  
59,51,43,35,27,19,11,3,  
61,53,45,37,29,21,13,5,  
63,55,47,39,31,23,15,7,  

2）逆置换
经过16次迭代运算后,得到`L16`、`R16`,将此作为输入，进行逆置换，逆置换正好是初始置换的逆运算，由此即得到密文输出。此算法是对称加密算法体系中的代表,在计算机网络系统中广泛使用。  

DES密钥太短，已经能被现代计算机暴力破解！

### 2. AES

高级加密标准（英语：Advanced Encryption Standard，缩写：AES），在密码学中又称Rijndael加密法，是美国联邦政府采用的一种区块加密标准。这个标准用来替代原先的DES，已经被多方分析且广为全世界所使用。  

#### 设计思想

Rijndael密码的设计力求满足以下3条标准：  
> 抵抗所有已知的攻击  
> 在多个平台上速度快，编码紧凑  
> 设计简单  

AES加密数据块分组长度必须为128比特，密钥长度可以是128比特、192比特、256比特中的任意一个（如果数据块及密钥长度不足时，会补齐）。AES加密有很多轮的重复和变换。

#### AES加密步骤

AES加密过程是在一个4×4的字节矩阵上运作，这个矩阵又称为“状态（`state`）”，其初值就是一个明文区块（矩阵中一个元素大小就是明文区块中的一个`Byte`）。（Rijndael加密法因支持更大的区块，其矩阵行数可视情况增加）加密时，各轮AES加密循环（除最后一轮外）均包含4个步骤：  

1. `AddRoundKey` — 矩阵中的每一个字节都与该次轮秘钥（`round key`）做`XOR`运算；每个子密钥由密钥生成方案产生  
2. `SubBytes` — 通过非线性的替换函数，用查找表的方式把每个字节替换成对应的字节  
3. `ShiftRows` — 将矩阵中的每个横列进行循环式移位  
4. `MixColumns` — 为了充分混合矩阵中各个直行的操作。这个步骤使用线性转换来混合每列的四个字节  

最后一个加密循环中省略`MixColumns`步骤，而以另一个`AddRoundKey`取代.  

### 3. Present

在CHES2007上，Bogdanov等提出了PRESENT算法，该算法具有出色的硬件实现性能和简洁的轮函数设计。PRESENT密码算法与现有的轻量级分组密码算法TEA、MCRYPTON、HIGHT、SEA和CGEN相比，有着更简单的硬件实现，因此被称为超轻量级密码算法。  

#### Present加密步骤

PRESENT分组密码算法采用`SPN`结构，分组长度为64位，支持80位、128位两种密钥长度。共迭代31轮，每轮轮函数`F` 由轮密钥加、`S`盒代换、`P`置换3部分组成。  

加密过程如下：  

1. 轮密钥加：`64bit` 轮输入同轮密钥进行异或  
2. `S` 盒代换层：将轮密钥加`64bit` 输出查找16 个4 进4 出的`S` 盒  
3. `P` 置换层：通过置换表`P(i)`对`S` 盒代换`64bit` 输出按比特进行重新排列  

为提高算法安全性，PRESENT 在第31 轮后使用`64bit` 密钥`K32` 进行后期白化操作  

### 4. 扩展欧几里得算法

#### 乘法逆元的定义

**`A * X MOD N == 1`**则称X为A关于模N的乘法逆元。  

注：  
> 只有两个数互素的时候才会有乘法逆元  
> 两个数不互素是没有乘法逆元的  

### 5. 素性检测算法（Miller-Robin）

#### 定义

一个数是素数（也叫质数），当且仅当它的约数只有两个——1和它本身。规定这两个约数不能相同，因此1不是素数。对素数的研究属于数论范畴，你可以 看到许多数学家没事就想出一些符合某种性质的素数并称它为某某某素数。  

#### 素数性质

1. 素数的个数无限多（不存在最大的素数）
2. 存在任意长的一段连续数，其中的所有数都是合数（相邻素数之间的间隔任意大）
3. 所有大于2的素数都可以唯一地表示成两个平方数之差
4. 当n为大于2的整数时，`2^n+1`和`2^n-1`两个数中，如果其中一个数是素数，那么另一个数一定是合数
5. 如果`p`是素数，`a`是小于`p`的正整数，那么`a^(p-1) mod p=1`

#### Miller-Robin

算法是基于费马小定理（`format`），二次探测定理（`x*x%p==1` ，若P为素数，则x的解只能是`x=1`或者`x=p-1`）加上迭代乘法判断的Miller算法共同构成的。  

- 费尔马小定理

> 如果`p`是一个素数，且`0<a<p`，则`a^(p-1)%p=1`。利用费尔马小定理，对于给定的整数`n`，可以设计素数判定算法，通过计算`d=a^(n-1)%n`来判断`n`的素性，当`d!=1`时，`n`肯定不是素数，当`d=1`时，`n`很可能是素数  

- 二次探测定理

> 如果`p`是一个素数，且`0<x<p`，则方程`x^2%p=1`的解为`x=1`或`x=p-1`。利用二次探测定理，可以再利用费尔马小定理计算`a^(n-1)%n`的过程中增加对整数`n`的二次探测，一旦发现违背二次探测条件，即得出`n`不是素数的结论

## 源码地址

caomage的[个人主页](http://www.caomage.com)  
caomage的[github](https://github.com/usecodelee/encryption-algorithm)  
