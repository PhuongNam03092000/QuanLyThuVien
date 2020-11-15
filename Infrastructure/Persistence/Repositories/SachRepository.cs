using Domain.Entities;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Persistence.Repositories
{
    public class SachRepository : EFRepository<Sach>, ISachRepository
    {
        public SachRepository(QLTVContext context) : base(context)
        {
        }

        public IEnumerable<Sach> Filter(string sortOrder, string theLoaiSach, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Sachs.AsQueryable();

            if (!string.IsNullOrEmpty(theLoaiSach))
            {
                query = query.Where(m => m.TheLoai == theLoaiSach);
            }
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.TenSach.Contains(searchString));
            }

            SortSachs(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public IEnumerable<string> GetTheLoais()
        {
            return context.Sachs
                            .OrderBy(m => m.TheLoai)
                            .Select(m => m.TheLoai)
                            .Distinct();
        }

        private static void SortSachs(string sortOrder, ref IQueryable<Sach> query)
        {
            switch (sortOrder)
            {
                case "tensach_desc":
                    query = query.OrderByDescending(m => m.TenSach);
                    break;

                case "tensach":
                    query = query.OrderBy(m => m.TenSach);
                    break;

                case "theloai_desc":
                    query = query.OrderByDescending(m => m.TheLoai);
                    break;

                case "theloai":
                    query = query.OrderBy(m => m.TheLoai);
                    break;

                case "tacgia_desc":
                    query = query.OrderByDescending(m => m.TacGia);
                    break;

                case "tacgia":
                    query = query.OrderBy(m => m.TacGia);
                    break;

                case "nhaxuatban_desc":
                    query = query.OrderByDescending(m => m.NhaXuatBan);
                    break;

                case "nhaxuatban":
                    query = query.OrderBy(m => m.NhaXuatBan);
                    break;

                case "giabia_desc":
                    query = query.OrderByDescending(m => m.GiaBia);
                    break;

                case "giabia":
                    query = query.OrderBy(m => m.GiaBia);
                    break;

                case "vitri_desc":
                    query = query.OrderByDescending(m => m.ViTri);
                    break;

                case "vitri":
                    query = query.OrderBy(m => m.ViTri);
                    break;
            }
        }
    }
}