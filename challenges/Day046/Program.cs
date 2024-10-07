using System;
using System.Collections.Generic;
using System.Linq;

public class HuffmanNode
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }
}

public class HuffmanTree
{
    private List<HuffmanNode> nodes = new List<HuffmanNode>();
    public HuffmanNode Root { get; set; }
    public Dictionary<char, string> Codes { get; set; } = new Dictionary<char, string>();

    public void Build(string source)
    {
        var frequencies = source.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
        foreach (var symbol in frequencies)
        {
            nodes.Add(new HuffmanNode { Symbol = symbol.Key, Frequency = symbol.Value });
        }

        while (nodes.Count > 1)
        {
            nodes = nodes.OrderBy(node => node.Frequency).ToList();
            var left = nodes[0];
            var right = nodes[1];

            var parent = new HuffmanNode
            {
                Symbol = '*',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            nodes.Remove(left);
            nodes.Remove(right);
            nodes.Add(parent);
        }

        Root = nodes.FirstOrDefault();
        GenerateCodes(Root, "");
    }

    private void GenerateCodes(HuffmanNode node, string code)
    {
        if (node == null) return;

        if (node.Left == null && node.Right == null)
        {
            Codes[node.Symbol] = code;
        }

        GenerateCodes(node.Left, code + "0");
        GenerateCodes(node.Right, code + "1");
    }

    public string Encode(string input)
    {
        var encodedOutput = string.Empty;
        foreach (var symbol in input)
        {
            encodedOutput += Codes[symbol];
        }
        return encodedOutput;
    }

    public string Decode(string input)
    {
        var currentNode = Root;
        var decodedOutput = string.Empty;

        foreach (var bit in input)
        {
            currentNode = bit == '0' ? currentNode.Left : currentNode.Right;

            if (currentNode.Left == null && currentNode.Right == null)
            {
                decodedOutput += currentNode.Symbol;
                currentNode = Root;
            }
        }

        return decodedOutput;
    }
}

public class Program
{
    public static void Main()
    {
        var huffmanTree = new HuffmanTree();
        string input = "exemplo de compressao usando huffman";

        huffmanTree.Build(input);
        var encoded = huffmanTree.Encode(input);
        var decoded = huffmanTree.Decode(encoded);

        Console.WriteLine($"Entrada: {input}");
        Console.WriteLine($"Codificado: {encoded}");
        Console.WriteLine($"Decodificado: {decoded}");
    }
}
