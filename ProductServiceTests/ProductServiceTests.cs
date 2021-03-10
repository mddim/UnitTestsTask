using Mentormate.UnitTestsTask.Contracts;
using Mentormate.UnitTestsTask.Services;
using Moq;
using NUnit.Framework;

namespace ProductServiceTests
{
    public class ProductServiceTests
    {
        IProductRepository _productRepository;
        private readonly IPriceRepository _priceRepository;
        private readonly IDiscountRepository _discountRepository;
        Mock<IProductRepository> mock1 = new Mock<IProductRepository>();

        Mock<ProductService> productService = new Mock<ProductService>(mock1.Object, _priceRepository, _discountRepository);

        ProductService ps = new ProductService();
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}