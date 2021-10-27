using System;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form_StudentInfo : Form
    {
        public readonly string[] IT = { "Xử lý dữ liệu thống kê", "Công nghệ Dữ liệu lớn", "Kho dữ liệu và OLAP", "Hệ hỗ trợ ra quyết định", "Kỹ thuật lập trình Python", "Phân tích dữ liệu", 
        "Thực tập doanh nghiệp", "Quản trị doanh nghiệp", "Hệ thống quản trị quy trình nghiệp vụ", "Quản lý dự án công nghệ thông tin", "Hoạch định nguồn lực doanh nghiệp", "Quản trị quan hệ khách hàng",
        "Kiến trúc và tích hợp hệ thống", "Các công nghệ nền", "Tối ưu hóa công cụ tìm kiếm (SEO)", "Kỹ thuật phát triển hệ thống Web", "Mạng xã hội", "Thương mại điện tử", "Công nghệ Java",
        "Công nghệ lập trình đa nền tảng cho ứng dụng di động", "Giới thiệu ngành Công nghệ Thông tin", "Cơ sở hạ tầng công nghệ thông tin", "Quản lý thông tin", "Internet và công nghệ Web", 
        "Nhập môn bảo đảm và an ninh thông tin", "Thiết kế giao diện người dùng" };
        public readonly string[] InSy = { "Xây dựng HTTT trên các framework", "Phân tích thiết kế hệ thống thông tin", "Hệ quản trị cơ sở dữ liệu", "Quản lý dự án công nghệ thông tin", "Lập trình Java",
        "Hoạch định nguồn lực doanh nghiệp", "Phát triển ứng dụng web", "Cơ sở dữ liệu phân tán", "Khai thác dữ liệu", "Kho dữ liệu và OLAP", "Phân tích dữ liệu kinh doanh", 
        "Giới thiệu ngành Hệ thống thông tin", "Hệ thống thông tin kế toán", "Hệ hỗ trợ quyết định", "Thương mại điện tử", "Hệ thống thông tin quản lý", "Phân tích không gian", 
        "Hệ cơ sở dữ liệu không gian", "Nhập môn Hệ thống thông tin địa lý", "An toàn và bảo mật Hệ thống thông tin", "Sinh tin học (Bioinformatics)", "Điện toán đám mây", "Dữ liệu lớn", "Mạng xã hội",
        "Khóa luận tốt nghiệp", "Thực tập doanh nghiệp" };
        public readonly string[] CS = { "Các hệ cơ sở tri thức", "Biểu diễn tri thức và suy luận", "Trí tuệ nhân tạo nâng cao", "Hệ thống đa tác tử", "Khai thác dữ liệu và ứng dụng",
        "Lập trình symbolic trong trí tuệ nhân tạo", "Máy học nâng cao", "Các hệ giải bài toán thông minh", "Trí tuệ nhân tạo", "Máy học", "Xử lý ngôn ngữ tự nhiên", "Ngữ nghĩa học tính toán",
        "Xử lý ngôn ngữ tự nhiên nâng cao", "Các hệ thống hỏi-đáp", "Máy học trong xử lý ngôn ngữ tự nhiên", "Ngôn ngữ học ngữ liệu", "Dịch máy", "Nhập môn Thị giác máy tính", "Đồ họa máy tính",
        "Thị giác máy tính nâng cao", "Thị giác máy tính trong tương tác người – máy", "Nhận dạng", "Đồ họa game", "Truy vấn thông tin đa phương tiện", "Xử lý âm thanh và tiếng nói",
        "Tổng hợp tiếng nói", "Tính toán Đa phương tiện", "Trí tuệ nhân tạo nâng cao", "Máy học nâng cao", "Phương pháp luận nghiên cứu khoa học", 
        "Các vấn đề nghiên cứu và ứng dụng trong Khoa học Máy tính", "Thực tập", "Máy học trong Thị giác máy tính", "Đồ họa game", "Thực tại ảo", "Trực quan hóa thông tin", "Hệ suy diễn mờ",
        "Logic mờ và ứng dụng", "Xử lý ảnh và ứng dụng", "Mạng Neural và Thuật giải di truyền", "Truy xuất thông tin", "Web ngữ nghĩa", "Các vấn đề chọn lọc trong Thị giác máy tính", 
        "Các kĩ thuật học sâu và ứng dụng", "Khóa luận tốt nghiệp" };
        public readonly string[] SE = { "Giới thiệu ngành Kỹ thuật Phần mềm", "Nhập môn công nghệ phần mềm", "Phương pháp phát triển phần mềm hướng đối tượng", "Phương pháp mô hình hóa", 
        "Nhập môn phát triển game", "Nhập môn ứng dụng di động", "Đặc tả hình thức", "Công nghệ phần mềm chuyên sâu", "Phát triển phần mềm mã nguồn mở", "Giao tiếp người máy", "Kiểm chứng phần mềm", 
        "Quản lý dự án phát triển phần mềm", "Ngôn ngữ lập trình Java", "Điện toán đám mây", "Chuyên đề CSDL nâng cao", "Các phương pháp lập trình", "Công nghệ Web và ứng dụng", "Chuyên đề E-learning",
        "Xử lý song song", "Công nghệ Portal", "Máy học và các công cụ", "Công nghệ .NET", "Lập trình trên thiết bị di động", "Chuyên đề E-Government", "Chuyên đề E-Commerce", 
        "Một số thuật toán thông minh", "Phát triển ứng dụng VR", "Phát triển, vận hành, bảo trì phần mềm", "Chuyên đề các quy trình phát triển phần mềm hiện đại", "Kiến trúc phần mềm", "Kỹ thuật phân tích yêu cầu",
        "Chuyên đề J2EE", "Lập trình game nâng cao", "Thiết kế game", "Lập trình đồ họa 3 chiều với Direct 3D", "Phát triển và vận hành game", "Lập trình TTNT trong game", 
        "Lập trình game trên các thiết bị di động", "Thiết kế 3D game engine", "Đồ án 1", "Thực tập tốt nghiệp", "Đồ án 2", "Seminar các vấn đề hiện đại của Công nghệ Phần mềm", "Mẫu thiết kế", 
        "Nguyên lý thiết kế thế giới ảo", "Chuyên đề Mobile and Pervasive Computing" };
        public readonly string[] CE = { "Vi xử lý – vi điều khiển", "Thiết kế luận lý số", "Thực hành Kiến trúc Máy tính", "Lý thuyết mạch điện", "Các thiết bị và mạch điện tử",
        "Thiết kế hệ thống số với HDL", "Thiết kế hệ thống nhúng", "Thiết kế vi mạch số", "Thiết kế vi mạch tương tự", "Thiết kế hệ thống SoC", "Thiết kế hệ thống nhúng không dây", 
        "Trí tuệ nhân tạo cho IoT", "Đồ án chuyên ngành Thiết kế vi mạch và phần cứng", "Đồ án chuyên ngành Hệ thống nhúng và IoT", "Tiếng Anh chuyên ngành KTMT", "Thiết kế vi mạch hỗn hợp", 
        "Tự động hóa thiết kế vi mạch", "Kỹ thuật thiết kế kiểm tra", "Xử lý tín hiệu số và Ứng dụng", "Kỹ thuật hệ thống máy tính", "Chuyên đề thiết kế vi mạch 1", "Chuyên đề thiết kế vi mạch 2", 
        "Điều khiển tự động", "Logic mờ và ứng dụng", "Lập trình nhúng trên các thiết bị di động", "Tương tác người máy", "Lập trình hệ thống", "Công nghệ IoT và Ứng dụng", 
        "Trí tuệ nhân tạo cho hệ thống nhúng", "Hệ thống thông minh", "Trí tuệ nhân tạo cho xe tự hành", "Kiến trúc IoT: Giao thức mạng và bảo mật", "Thiết kế Antenna tích hợp cho thiết bị IoT", 
        "Chuyên đề thiết kế hệ thống nhúng 1", "Chuyên đề thiết kế hệ thống nhúng 2", "Đồ án 1", "Đồ án 2", "Thực tập doanh nghiệp", "Khóa luận tốt nghiệp", "Luận văn chuyên sâu đặc thù" };
        public readonly string[] CNaDS = { "Lập trình", "Mạng máy tính", "Thực hành nghề nghiệp", "Thiết kế và phát triển cơ sở dữ liệu", "Bảo mật", "Quản lý dự án máy tính thành công", 
        "Thiết kế và phát triển website", "Kiến trúc máy tính", "Dự án nghiên cứu", "Công nghệ kinh doanh thông minh", "Cấu trúc dữ liệu và giải thuật", "Internet of Things", "An toàn mạng máy tính",
        "Pháp chứng kỹ thuật số", "Quản lý an toàn thông tin", "Hoạt động an ninh mạng", "Công nghệ mạng nâng cao", "Thiết kế và quản lý mạng", "Dự án cá nhân"};
        public readonly string[] InSe = { "Giới thiệu ngành An toàn Thông tin", "Lập trình mạng căn bản", "An toàn Mạng máy tính", "Cơ chế hoạt động của mã độc", "Quản trị mạng và hệ thống",
        "Mật mã học", "Lập trình hệ thống", "Đồ án chuyên ngành", "Hệ thống tìm kiếm, phát hiện và ngăn ngừa xâm nhập", "An toàn mạng không dây và di động", 
        "Quản lý rủi ro và an toàn thông tin trong doanh nghiệp", "Kỹ thuật phân tích mã độc", "Bảo mật web và ứng dụng", "Pháp chứng kỹ thuật số", "Công nghệ Internet of Things hiện đại",
        "Bảo mật Internet of things", "An ninh nhân sự, định danh và chứng thực", "An toàn dữ liệu, khôi phục thông tin sau sự cố", "An toàn mạng máy tính nâng cao", "An toàn kiến trúc hệ thống",
        "Lập trình an toàn và khai thác lỗ hổng phần mềm", "Phương pháp học máy trong an toàn thông tin", "An toàn thông tin trong kỷ nguyên máy tính lượng tử", "Thực tập doanh nghiệp", 
        "Hệ thống nhúng Mạng không dây", "Lập trình ứng dụng Web", "Tấn công mạng", "Đồ án chuyên ngành", "Khóa luận tốt nghiệp" };
        public readonly string[] CNaDT = { "Giới thiệu ngành MMT&TTDL", "An toàn mạng máy tính", "Hệ thống nhúng mạng không dây", "Truyền dữ liệu", "Lập trình mạng căn bản", 
        "Phát triển ứng dụng trên thiết bị di động", "Quản trị mạng và hệ thống", "Thiết kế mạng", "Đánh giá hiệu năng hệ thống mạng máy tính", "Công nghệ Internet of things hiện đại",
        "Hệ tính toán phân bố", "Công nghệ truyền thông đa phương tiện", "Công nghệ mạng viễn thông", "Giải thuật xử lý song song và phân bố", "Thương mại điện tử và triển khai ứng dụng",
        "Tính toán lưới", "Pháp chứng kỹ thuật số", "Tấn công mạng", "An toàn mạng không dây và di động", "Quản lý rủi ro và an toàn thông tin trong doanh nghiệp", "An toàn mạng máy tính nâng cao",
        "Bảo mật Internet of things", "Hệ điều hành Linux", "Lập trình ứng dụng web", "Phân tích thiết kế hệ thống Truyền thông và Mạng", "Lập trình hệ thống", "Lý thuyết thông tin", 
        "Lập trình ứng dụng mạng", "Công nghệ thoại IP", "Xây dựng chuẩn chính sách an toàn thông tin trong doanh nghiệp", "Hệ thống tìm kiếm, phát hiện và ngăn ngừa xâm nhập", 
        "Truyền thông xã hội và kinh doanh", "Đồ án chuyên ngành", "Thực tập doanh nghiệp", "Khóa luận tốt nghiệp", "Xử lý tín hiệu trong Truyền thông", "AI ứng dụng trong mạng và truyền thông", 
        "Bảo mật Internet", "Thiết bị mạng và truyền thông đa phương tiện" };
        public readonly string[] EC = { "Giới thiệu ngành Thương mại điện tử", "Kinh tế học đại cương", "Tiếp thị căn bản", "Phân tích thiết kế quy trình nghiệp vụ doanh nghiệp", "Tiếp thị trực tuyến",
        "Thiết kế hệ thống TMĐT", "Quản trị quan hệ khách hàng và nhà cung cấp", "Hệ thống thanh toán trực tuyến", "Quản trị dự án TMĐT", "Pháp luật trong TMĐT", "An toàn và bảo mật TMĐT", 
        "Nhập môn quản trị chuỗi cung ứng", "Quản trị chiến lược kinh doanh điện tử", "Quản trị sản xuất", "Quản trị tài chính doanh nghiệp", "Quản trị kênh phân phối", "Quản trị bán hàng", 
        "Quản trị nhân lực", "Quản trị doanh nghiệp", "Nguyên lý kế toán", "Pháp luật trong thương mại điện tử", "Khóa luận tốt nghiệp" };
        public readonly string[] DaSc = { "Giới thiệu ngành Khoa học dữ liệu", "Thống kê và xác suất chuyên sâu", "Phân tích và trực quan dữ liệu", "Học máy thống kê", "Thu thập và tiền xử lý dữ liệu",
        "Phân tích dữ liệu lớn", "Deep Learning trong khoa học dữ liệu", "Đồ án khoa học dữ liệu và ứng dụng", "Tính toán song song & phân tán", "Tối ứu hoá và ứng dụng", "Hệ khuyến nghị", 
        "Phân tích thống kê đa biến", "Thống kê Bayes", "Thiết kế và phân tích thực nghiệm", "Xử lý ngôn ngữ tự nhiên cho Khoa học Dữ liệu", "Các giải thuật khai phá dữ liệu lớn", 
        "Phân tích dữ liệu lớn trong tài chính", "Phân tích dữ liệu truyền thông xã hội", "Phân tích dữ liệu chuỗi thời gian và ứng dụng", "Mô hình đồ thị xác suất", 
        "Khoá luận tốt nghiệp" };

        public Form_StudentInfo()
        {
            InitializeComponent();
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_ID.Text) || string.IsNullOrEmpty(textBox_Name.Text) || (checkBox_Male.Checked == false && checkBox_Female.Checked == false) || comboBox_Profession.SelectedIndex == -1 || listView_SelectedSubjects.Items.Count == 0)
            {
                MessageBox.Show("Lam on nhap day du thong tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (dataGridView_StudentInfo.RowCount > 1)
                {
                    for (int i = 0; i < dataGridView_StudentInfo.RowCount; i++)
                    {
                        if (dataGridView_StudentInfo.Rows[i].Cells[0].Value != null && textBox_ID.Text == dataGridView_StudentInfo.Rows[i].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("MSSV da ton tai", "Lỗi", MessageBoxButtons.OK);
                            return;
                        }
                    }
                }
            }
            string[] data = { textBox_ID.Text, textBox_Name.Text, comboBox_Profession.Text, checkBox_Male.Checked ? "Nam" : "Nữ", listView_SelectedSubjects.Items.Count.ToString() };
            dataGridView_StudentInfo.Rows.Add(data);
            textBox_ID.Clear();
            textBox_Name.Clear();
            comboBox_Profession.SelectedIndex = -1;
            listView_SelectedSubjects.Clear();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listView_SelectedSubjects.Items.Count; i++)
            {
                listView_SelectedSubjects.Items[i].Selected = true;
            }           
            for (int i = 0; i < listView_SelectedSubjects.Items.Count; i++)
            {
                if (listView_SelectedSubjects.Items[i].Selected)
                {
                    listView_Subjects.Items.Add(listView_SelectedSubjects.Items[i].Text);
                    listView_SelectedSubjects.Items[i].Remove();
                    i--;
                }
            }
            listView_Subjects.Sorting = SortOrder.Ascending;
        }

        private void comboBox_Profession_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Profession.SelectedIndex)
            {
                case 0:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < IT.Length; i++)
                    {    
                        listView_Subjects.Items.Add(IT[i]);
                    }
                    break;
                case 1:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < InSy.Length; i++)
                    {                        
                        listView_Subjects.Items.Add(InSy[i]);
                    }
                    break;
                case 2:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < CS.Length; i++)
                    {
                        listView_Subjects.Items.Add(CS[i]);
                    }
                    break;
                case 3:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < SE.Length; i++)
                    {
                        listView_Subjects.Items.Add(SE[i]);
                    }
                    break;
                case 4:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < CE.Length; i++)
                    {
                        listView_Subjects.Items.Add(CE[i]);
                    }
                    break;
                case 5:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < CNaDS.Length; i++)
                    {
                        listView_Subjects.Items.Add(CNaDS[i]);
                    }
                    break;
                case 6:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < CNaDT.Length; i++)
                    {
                        listView_Subjects.Items.Add(CNaDT[i]);
                    }
                    break;
                case 7:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < InSe.Length; i++)
                    {
                        listView_Subjects.Items.Add(InSe[i]);
                    }
                    break;                     
                case 8:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < EC.Length; i++)
                    {
                        listView_Subjects.Items.Add(EC[i]);
                    }
                    break;
                case 9:
                    listView_Subjects.Clear();
                    listView_SelectedSubjects.Clear();
                    listView_Subjects.Columns.Add("", 330);
                    for (int i = 0; i < DaSc.Length; i++)
                    {
                        listView_Subjects.Items.Add(DaSc[i]);
                    }
                    break;
                default:
                    break;
            }
            listView_Subjects.Sorting = SortOrder.Ascending;
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            if (listView_SelectedSubjects.Items.Count == 0) listView_SelectedSubjects.Columns.Add("", 300);

            for (int i = 0; i < listView_Subjects.Items.Count; i++)
            {
                if (listView_Subjects.Items[i].Selected)
                {
                    listView_SelectedSubjects.Items.Add(listView_Subjects.Items[i].Text);
                    listView_Subjects.Items[i].Remove();
                    listView_Subjects.Sorting = SortOrder.Ascending;
                    listView_SelectedSubjects.Sorting = SortOrder.Ascending;
                    i--;
                }
            }
        }

        private void button_Unselect_Click(object sender, EventArgs e)
        {
            if (listView_Subjects.Items.Count == 0) listView_Subjects.Columns.Add("", 300);
            
            for (int i = 0; i < listView_SelectedSubjects.Items.Count; i++)
            {
                if (listView_SelectedSubjects.Items[i].Selected)
                {
                    listView_Subjects.Items.Add(listView_SelectedSubjects.Items[i].Text);
                    listView_SelectedSubjects.Items[i].Remove();
                    listView_Subjects.Sorting = SortOrder.Ascending;
                    listView_SelectedSubjects.Sorting = SortOrder.Ascending;
                    i--;
                }
            }
        }

        private void checkBox_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Male.Checked == true) checkBox_Female.Checked = false;
        }

        private void checkBox_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Female.Checked == true) checkBox_Male.Checked = false;
        }
    }
}